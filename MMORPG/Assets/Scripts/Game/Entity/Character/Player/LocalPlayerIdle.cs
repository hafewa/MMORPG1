using UnityEngine;

namespace MMORPG.Game
{
    public class LocalPlayerIdle : LocalPlayerAbility
    {
        public override void OnStateEnter()
        {
            Brain.NetworkUploadTransform(OwnerStateId);
            Brain.AnimationController.StopMovement();
        }

        [StateCondition]
        public bool CanMovement()
        {
            return !Brain.ActorController.IsPreventingMovement;
        }
    }

}
