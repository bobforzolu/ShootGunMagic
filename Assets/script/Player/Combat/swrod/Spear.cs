using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon
{
    public override void Attack()
    {
        base.Attack();
        attackCount++;
        animator.SetBool("Attack", true);
        animator.SetInteger("attackCount", attackCount);
        if (attackCount >= 3)
        {
            attackCount = 0;
        }
    }

    public override void ExitAttack()
    {
        base.ExitAttack();
        animator.SetBool("Attack", false);


    }
}
