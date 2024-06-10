using Common.Proto.Fight;
using MMORPG.Event;
using MMORPG.System;
using MMORPG.Tool;
using QFramework;
using Serilog;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MMORPG.Game
{
    public class LocalPlayerAttack : LocalPlayerAbility, IController
    {
        private bool _prepareFire;
        private INetworkSystem _network;

        public override void OnStateInit()
        {
            _network = this.GetSystem<INetworkSystem>();
            _network.Receive<SpellFailResponse>(OnReceivedSpellFail)
                .UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        public override void OnStateEnter()
        {
            Spell();
        }

        /// <summary>
        /// 发送攻击请求, 在响应成功后正式攻击
        /// </summary>
        public void Spell()
        {
            if (_prepareFire) return;

            if (OwnerState.Brain.HandleWeapon == null) return;

            var weapon = OwnerState.Brain.HandleWeapon.CurrentWeapon;

            if (weapon == null) return;

            if (weapon.CanUse)
            {
                _prepareFire = true;
                _network.SendToServer(new SpellRequest()
                {
                    Info = new()
                    {
                        SkillId = weapon.WeaponId,
                        CasterId = Brain.CharacterController.Entity.EntityId
                    }
                });

            }
        }

        private void OnReceivedSpellFail(SpellFailResponse response)
        {
            if (response.Reason == CastResult.Success)
            {
                OwnerState.Brain.HandleWeapon.ShootStart();
            }
            else
            {
                Log.Error($"攻击请求失败! 原因:{response.Reason}");
            }
            _prepareFire = false;
        }

        [StateCondition]
        public bool InputFire()
        {
            return Brain.InputControls.Player.Fire.inProgress;
        }

        public override void OnStateExit()
        {
        }

        public IArchitecture GetArchitecture()
        {
            return GameApp.Interface;
        }
    }
}
