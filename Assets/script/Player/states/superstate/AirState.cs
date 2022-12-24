using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirState : State
{

    protected bool isDash;
    protected int Xinput;
    protected bool isGrounded;

    public AirState(PlayerController controller, Statemachine statemachine) : base(controller, statemachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
        controller.animator.SetBool("jump", true);
    }

    public override void Exit()
    {
        base.Exit();
        controller.animator.SetBool("jump", false);

    }

    public override void Update()
    {
        base.Update();
        isDash = controller.input.DashInput;
        Xinput = controller.input.normInputX;
        isGrounded = controller.core.collison_Sense.GroundCheck();
        if (controller.core.movement.RB.velocity.y < 0)
        {
            controller.core.movement.FasterLanding(controller);
        }
        if (isDash && controller.dash.CheckIfCanDash())
        {
            controller.input.UseDashInput();
            statemachine.CangeState(controller.dash);

        }
        else if (isGrounded)
        {
            statemachine.CangeState(controller.idleState);
        }
        else
        {
            controller.core.movement.CheckIfShouldFlip(Xinput, true);
            controller.core.movement.SetVelocityX(controller.PlayerStats.movementvelocity * 0.8f * Xinput);
        }
    }

}
