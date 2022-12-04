using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence.Game_utilities.Enemy
{
    public abstract class EnemyType : MonoBehaviour,IDamagable
    {
        public  int health;

        protected EnemyType(int health)
        {
            this.health = health;
        }

        public virtual void TakeDamage(float Damage)
        {

        }
    }
}
