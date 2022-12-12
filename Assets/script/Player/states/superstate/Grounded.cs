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
        isSwitchactiveammo = controller.input.ReasourceChange;
        isAttack = controller.input.isAttack;
        isSwithcActivewepon = controller.input.isSwitch;
        Xinput = controller.input.normInputX;


        if (isAttack)
        {
            controller.input.OnAttackPressed();
            statemachine.CangeState(controller.AttackState);
        }else if (isSwithcActivewepon)
        {
            statemachine.CangeState(controller.weaponChange);

        }else if (isSwitchactiveammo)
        {
            controller.input.OnRessorcePressed();
            controller.guneventHandler.AmmoSwitchTriggerRight();
        }
    }
}
