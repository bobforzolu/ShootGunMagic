using Laurence.Game_utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class WalkingState : Grounded
    {
        public WalkingState(PlayerController controller, Statemachine statemachine) : base(controller, statemachine)
        {
        }

        public override void AbilityFinish()
        {
            base.AbilityFinish();

        }

        public override void Enter()
        {
            base.Enter();
            controller.animator.SetBool("run", true);

        }

        public override void Exit()
        {
            base.Exit();
            controller.animator.SetBool("run", false);

        }

        public override void Update()
        {
            base.Update();
            controller.core.movement.CheckIfShouldFlip(Xinput,true);

            controller.core.movement.SetVelocityX(Xinput * controller.PlayerStats.movementvelocity);

            if (Xinput == 0)
            {
                statemachine.CangeState(controller.idleState);
            }
        }
    }
}
