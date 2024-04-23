﻿using Common.Proto.Entity;
using Common.Proto.Event.Space;
using MMORPG;
using QFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.EventSystems.EventTrigger;

public class NetworkEntityEnterEvent
{
    public int EntityId { get; }
    public Vector3 Position { get; }
    public Quaternion Rotation { get; }

    public NetworkEntityEnterEvent(int entityId, Vector3 position, Quaternion rotation)
    {
        EntityId = entityId;
        Position = position;
        Rotation = rotation;
    }
}

public class NetworkEntitySyncEvent
{
    public int EntityId { get; }
    public Vector3 Postion { get; }
    public Quaternion Rotation { get; }

    public NetworkEntitySyncEvent(int entityId, Vector3 position, Quaternion rotation)
    {
        EntityId = entityId;
        Postion = position;
        Rotation = rotation;
    }
}

public interface IEntityManagerSystem : ISystem
{
    public Entity SpawnEntity(
        Entity prefab,
        int entityId,
        Vector3 position,
        Quaternion rotation,
        bool isMine);

    public Dictionary<int, Entity> GetEntityDict(bool isMine);
}


public class EntityManagerSystem : AbstractSystem, IEntityManagerSystem
{
    public Dictionary<int, Entity> _mineEntityDict { get; } = new();
    public Dictionary<int, Entity> _notMineEntityDict { get; } = new();

    public Dictionary<int, Entity> GetEntityDict(bool isMine)
    {
        return isMine ? _mineEntityDict : _notMineEntityDict;
    }

    public void RegisterNewEntity(Entity entity)
    {
        Debug.Assert(
            !(_mineEntityDict.ContainsKey(entity.EntityId) ||
            _notMineEntityDict.ContainsKey(entity.EntityId)));

        if (entity.IsMine)
        {
            _mineEntityDict[entity.EntityId] = entity;
        }
        else
        {
            _notMineEntityDict[entity.EntityId] = entity;
        }
        this.SendEvent(new EntityEnterEvent(entity));
    }

    public Entity SpawnEntity(Entity prefab, int entityId, Vector3 position, Quaternion rotation, bool isMine)
    {
        Debug.Assert(
            !(_mineEntityDict.ContainsKey(entityId) ||
            _notMineEntityDict.ContainsKey(entityId)));

        var entity = GameObject.Instantiate(prefab, position, rotation);
        entity.transform.SetPositionAndRotation(position, rotation);

        entity.SetEntityId(entityId);
        entity.SetIsMine(isMine);

        if (entity.IsMine)
        {
            _mineEntityDict[entity.EntityId] = entity;
        }
        else
        {
            _notMineEntityDict[entity.EntityId] = entity;
        }
        Logger.Info("Game", $"实体生成成功: id:{entityId}, position:{position}, rotation:{rotation}, isMine:{isMine}");
        this.SendEvent(new EntityEnterEvent(entity));
        return entity;
    }

    protected override void OnInit()
    {
        this.GetSystem<INetworkSystem>().ReceiveEvent<EntityEnterResponse>(OnEntityEnterReceived);
        this.GetSystem<INetworkSystem>().ReceiveEvent<EntitySyncResponse>(OnEntitySyncReceived);
    }

    private void OnEntityEnterReceived(EntityEnterResponse response)
    {
        foreach (var entity in response.EntityList)
        {
            var e = new NetworkEntityEnterEvent(
                entity.EntityId,
                entity.Position.ToVector3(),
                Quaternion.Euler(entity.Direction.ToVector3()));

            Logger.Info("Game", $"实体({entity.EntityId})加入: Position:{e.Position}, Rotation:{e.Rotation}");
            this.SendEvent(e);
        }
    }

    private void OnEntitySyncReceived(EntitySyncResponse response)
    {
        this.SendEvent(new NetworkEntitySyncEvent(
            response.EntitySync.Entity.EntityId,
            response.EntitySync.Entity.Position.ToVector3(),
            Quaternion.Euler(response.EntitySync.Entity.Direction.ToVector3())));
    }
}