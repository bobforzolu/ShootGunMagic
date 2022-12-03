using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : AbilityState
{
    public WepontController weapon;
    public AttackState(PlayerController controller, Statemachine statemachine, WepontController weapon) : base(controller, statemachine)
    {
        this.weapon = weapon;
    }

    public override void Enter()
    {
        base.Enter();
        weapon.EnterAttack();
    }

    public override void Exit()
    {
        base.Exit();
        weapon.LeaveAttack();
    }

    public override void Update()
    {
        base.Update();
        
    }
}
