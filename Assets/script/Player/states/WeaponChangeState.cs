using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence.script.Player
{
    public class WeaponChangeState : AbilityState
    {
        public WeaponChangeState(PlayerController controller, Statemachine statemachine) : base(controller, statemachine)
        {
        }

        public override void AbilityFinish()
        {
            base.AbilityFinish();
        }

        public override void Exit()
        {
            base.Exit();
            controller.animator.SetBool("skill", false);

        }

        public override void Update()
        {
            base.Update();
            
        }

        public override void Enter()
        {
            base.Enter();
            controller.animator.SetBool("skill", true);
            controller.wepont.WeaponChangeTrigger();
        }
    }
}
