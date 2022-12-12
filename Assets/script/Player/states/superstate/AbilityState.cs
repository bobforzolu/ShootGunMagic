using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityState : State
{
    protected bool isAbilityFinish;

    public AbilityState(PlayerController controller, Statemachine statemachine) : base(controller, statemachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
        isAbilityFinish = false;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (isAbilityFinish)
        {
            statemachine.CangeState(controller.idleState);
        }
    }

    public override void AbilityFinish()
    {
        base.AbilityFinish();
        isAbilityFinish = true;
    }
}
