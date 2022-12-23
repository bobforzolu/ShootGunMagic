using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class Jump : AbilityState
    {
        public Jump(PlayerController controller, Statemachine statemachine) : base(controller, statemachine)
        {

        }

        public override void Enter()
        {
            base.Enter();
            controller.core.movement.SetVelocityY(controller.PlayerStats.JumpForce);
            isAbilityFinish = true;
        }
    }
}
