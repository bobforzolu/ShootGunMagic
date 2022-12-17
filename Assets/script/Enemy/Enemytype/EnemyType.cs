using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence.Game_utilities.Enemy
{
    public abstract class EnemyType : MonoBehaviour,IDamagable
    {
        [SerializeField]public  int health;

        public virtual void start()
        {

        }

        public virtual void TakeDamage(int Damage)
        {
            health -= Damage;
            if(health <= 0)
            {
                OnDeath();
            }

        }

        public virtual void OnDeath()
        {

        }
    }
}
