using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityState : State
{
    protected bool isAbilityFinish;
    public bool isGrounded;

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
        isGrounded = controller.core.collison_Sense.GroundCheck();
        if (isAbilityFinish && isGrounded)
        {
            statemachine.CangeState(controller.idleState);
        }
        else if(isAbilityFinish && !isGrounded)
        {
            statemachine.CangeState(controller.airState);

        }
    }

    public override void AbilityFinish()
    {
        base.AbilityFinish();
        isAbilityFinish = true;
    }
}
