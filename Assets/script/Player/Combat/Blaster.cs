using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : Weapon
{
    public override void Attack()
    {
        base.Attack();
        animator.SetBool("Shoot", true);
        
    }

    public override void ExitAttack()
    {
        base.ExitAttack();
        animator.SetBool("Shoot", false);

    }
}
