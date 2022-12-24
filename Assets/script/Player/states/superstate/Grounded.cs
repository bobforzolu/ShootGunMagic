using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : State
{
    public Grounded(PlayerController controller, Statemachine statemachine) : base(controller, statemachine)
    {
    }
    protected bool isGrounded;
    protected bool isAttack;

    protected bool isSwithcActivewepon;
    protected bool isSwitchactiveammo;
    protected bool jump;
    protected bool isDash;
    protected int Xinput;


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
        isGrounded = controller.core.collison_Sense.GroundCheck();
        if (controller.inputEvent.GetInput)
        {
            isSwitchactiveammo = controller.input.ReasourceChange;
            isAttack = controller.input.isAttack;
            isSwithcActivewepon = controller.input.isSwitch;
            Xinput = controller.input.normInputX;
            jump = controller.input.JumpInput;
            isDash = controller.input.DashInput;
        }
        else
        {
            Xinput = 0;
            isAttack = false;
            
           
        }
        if (!isGrounded)
                {
                    statemachine.CangeState(controller.airState);
                }

        if (isAttack)
        {
            controller.input.OnAttackPressed();
            statemachine.CangeState(controller.AttackState);
        } else if (jump) {
            controller.input.Jump_Is_Pressed();
            statemachine.CangeState(controller.jump);
            

        }
        else if (isSwithcActivewepon)
        {
            controller.input.UseSwitchInput();
            statemachine.CangeState(controller.weaponChange);

        } else if (isDash && controller.dash.CheckIfCanDash())
        {
            controller.input.UseDashInput();
            statemachine.CangeState(controller.dash);
        }
    }
}
