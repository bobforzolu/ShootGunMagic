using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : State
{
    public Grounded(PlayerController controller, Statemachine statemachine) : base(controller, statemachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (controller.input.isAttack)
        {
            statemachine.CangeState(controller.AttackState);
        }else if (controller.input.isSwitch)
        {
            statemachine.CangeState(controller.weaponChange);

        }
    }
}
