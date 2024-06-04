using Common.Proto.Entity;
using Common.Proto.Map;
using QFramework;
using MMORPG.System;
using MMORPG.Tool;
using UnityEngine;

namespace MMORPG.Game
{
    public struct EntityTransformSyncData
    {
        public EntityView Entity;
        public Vector3 Position;
        public Quaternion Rotation;
        public int StateId;
        public byte[] Data;
    }

    public class EntityManager : MonoBehaviour, IController, ICanSendEvent
    {
        private IEntityManagerSystem _entityManager;
        private IDataManagerSystem _dataManager;
        private ResLoader _resLoader = ResLoader.Allocate();

        private void Awake()
        {
            _entityManager = this.GetSystem<IEntityManagerSystem>();
            _dataManager = this.GetSystem<IDataManagerSystem>();

            this.GetSystem<INetworkSystem>().Receive<EntityEnterResponse>(OnEntityEnterReceived)
                .UnRegisterWhenGameObjectDestroyed(gameObject);
            this.GetSystem<INetworkSystem>().Receive<EntityLeaveResponse>(OnEntityLeaveReceived)
                .UnRegisterWhenGameObjectDestroyed(gameObject);
            this.GetSystem<INetworkSystem>().Receive<EntityTransformSyncResponse>(OnEntitySyncReceived)
                .UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        private void OnEntityLeaveReceived(EntityLeaveResponse response)
        {
            foreach (var id in response.EntityIds)
            {
                _entityManager.LeaveEntity(id);
            }
        }

        private void OnEntityEnterReceived(EntityEnterResponse response)
        {
            foreach (var data in response.Datas)
            {
                var entityId = data.EntityId;
                var position = data.Transform.Position.ToVector3();
                var rotation = Quaternion.Euler(data.Transform.Direction.ToVector3());
                
                var unitDefine = _dataManager.GetUnitDefine(data.UnitId);

                _entityManager.SpawnEntity(
                    _resLoader.LoadSync<EntityView>(unitDefine.Resource),
                    entityId,
                    (EntityType)data.EntityType,
                    position,
                    rotation);
            }
        }

        private void OnEntitySyncReceived(EntityTransformSyncResponse response)
        {
            var entityId = response.EntityId;
            var position = response.Transform.Position.ToVector3();
            var rotation = Quaternion.Euler(response.Transform.Direction.ToVector3());
            var entity = _entityManager.EntityDict[entityId];
            Debug.Assert(entity.EntityId == entityId);
            var data = new EntityTransformSyncData
            {
                Entity = entity,
                Position = position,
                Rotation = rotation,
                StateId = response.StateId,
                Data = response.Data.ToByteArray()
            };
            entity.HandleNetworkSync(data);
        }

        public IArchitecture GetArchitecture()
        {
            return GameApp.Interface;
        }

        void OnDestroy()
        {
            _resLoader.Recycle2Cache();
            _resLoader = null;
        }
    }
}
