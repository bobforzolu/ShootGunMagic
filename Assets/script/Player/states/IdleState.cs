using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : Grounded
{
    public IdleState(PlayerController controller, Statemachine statemachine) : base(controller, statemachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
        controller.animator.SetBool("idle", true);
    }
    

    public override void Exit()
    {
        base.Exit();
        controller.animator.SetBool("idle", false);
    }

    public override void Update()
    {
        base.Update();
       

        
        if(Xinput != 0)
        {
            statemachine.CangeState(controller.WalkState);

        }
    }
}
