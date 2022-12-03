using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public Animator animator;
    public int attackCount;
    public int currentAttackCount;
    public virtual void Attack()
    {




    }
    public virtual void ExitAttack()
    {
        
    }

    public virtual void Skill1()
    {

    }
    public virtual void Skill2()
    {

    }

}