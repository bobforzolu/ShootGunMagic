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
        weapon.EnterAttackTrigger();
    }

    public override void Exit()
    {
        base.Exit();
        weapon.LeaveAttackTrigger();
    }

    public override void Update()
    {
        base.Update();
        controller.core.movement.SetVelocityX(0);
        
    }

    public override void AnimationEventTrigger()
    {
        base.AnimationEventTrigger();
        controller.core.attack.Damage(damage());
    }
    public int damage()
    {
        int random = Random.Range(controller.PlayerStats.damage1, controller.PlayerStats.damage2);
        int value = random;
        return value;
    }
}
