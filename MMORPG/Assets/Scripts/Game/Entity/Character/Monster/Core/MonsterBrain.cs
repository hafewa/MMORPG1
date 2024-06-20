using MMORPG.Common.Proto.Fight;
using MMORPG.Common.Proto.Monster;
using MMORPG.Event;
using MMORPG.Tool;
using QFramework;
using Sirenix.OdinInspector;
using UnityEngine;
using NotImplementedException = System.NotImplementedException;

namespace MMORPG.Game
{
    public class MonsterBrain : MonoBehaviour, IController
    {
        public Animator Animator;

        public FSM<ActorState> FSM = new ();

        public EntityTransformSyncData Data;

        [Required]
        public CharacterController CharacterController;

        public Transform DamageNumberPoint;

        [Title("Feedbacks")]
        public FeedbacksManager HurtFeedbacks;
        public FeedbacksManager CritHurtFeedbacks;
        public FeedbacksManager MissHurtFeedbacks;

        private void Awake()
        {
            CharacterController.Entity.OnTransformSync += OnTransformEntitySync;

            this.RegisterEvent<EntityHurtEvent>(e =>
            {
                if (e.Wounded == CharacterController.Entity)
                {
                    OnHurt(e);
                }
            });
        }

        private void OnHurt(EntityHurtEvent e)
        {
            if (e.IsCrit)
            {
                if (CritHurtFeedbacks != null)
                    CritHurtFeedbacks.Play();
            }
            else if (e.IsMiss)
            {
                if (MissHurtFeedbacks != null)
                    MissHurtFeedbacks.Play();
            }
            else
            {
                if (HurtFeedbacks != null)
                    HurtFeedbacks.Play();
            }

            if (!e.IsMiss)
            {
                Animator.SetTrigger("Hurt");
            }
            if (e.IsMiss)
            {
                LevelManager.Instance.TakeText(DamageNumberPoint.position, "Miss");
            }
            else
            {
                LevelManager.Instance.TakeDamage(DamageNumberPoint.position, e.Amount, e.IsCrit);
            }
        }

        private void OnTransformEntitySync(EntityTransformSyncData data)
        {
            ActorState state = (ActorState)data.StateId;
            if (FSM.CurrentStateId != state)
            {
                FSM.ChangeState(state);
            }

            CharacterController.SmoothMove(CalculateGroundPosition(data.Position, 6));
            CharacterController.SmoothRotate(data.Rotation);
        }

        private void Start()
        {
            FSM.AddState(ActorState.Idle, new IdleState(FSM, this));
            FSM.AddState(ActorState.Move, new MoveState(FSM, this));
            FSM.AddState(ActorState.Skill, new AttackState(FSM, this));
            FSM.StartState(ActorState.Idle);
        }

        private void Update()
        {
            FSM.Update();
        }

        private void FixedUpdate()
        {
            FSM.FixedUpdate();
        }

        private void OnGUI()
        {
            FSM.OnGUI();
        }

        private void OnDestroy()
        {
            FSM.Clear();
        }

        public Vector3 CalculateGroundPosition(Vector3 position, int layer)
        {
            int layerMask = 1 << layer;
            if (Physics.Raycast(position, Vector3.down, out var hit, Mathf.Infinity, layerMask))
            {
                return hit.point;
            }
            return position;
        }

        public IArchitecture GetArchitecture()
        {
            return GameApp.Interface;
        }
    }

}
