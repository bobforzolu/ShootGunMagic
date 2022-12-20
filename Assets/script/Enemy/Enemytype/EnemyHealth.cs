using Laurence.Game_utilities.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class EnemyHealth : MonoBehaviour, IDamagable
    {
        public EnemyData enemyData;

        private void Start()
        {
            enemyData.health = enemyData.maxhealth;
        }

        public void TakeDamage(int Damage)
        {
           
            enemyData.health -= Damage;
            if (enemyData.health <= 0)
            {
                OnDeath();
            }
        }
        public  void OnDeath()
        {
            if(transform.parent == null)
                Destroy(gameObject, 0.1f);
            else
                 Destroy(transform.parent.gameObject, 0.1f);
        }
    }
}
