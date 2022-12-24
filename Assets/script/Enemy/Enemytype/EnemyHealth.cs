using Laurence.Game_utilities.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class EnemyHealth : MonoBehaviour, IDamagable
    {
        public EnemyData enemyData;
        public LootBag loot;

        private void Start()
        {
            enemyData.health = enemyData.maxhealth;
            loot = GetComponent<LootBag>();
        }

        public void TakeDamage(int Damage)
        {
           
            enemyData.health -= Damage;
            if (enemyData.health <= 0)
            {   
                DropLot(gameObject.transform);
                OnDeath();
            }
        }
        public  void OnDeath()
        {

            enemyData.health = enemyData.maxhealth;
            if (transform.parent == null)
            {
                gameObject.SetActive(false);

            }
            else
            {
                transform.parent.gameObject.SetActive(false);


            }
        }
        public void DamageFlash()
        {

        }
        public void DropLot(Transform pos)
        {
            if(enemyData.health <= 0)
                loot.SummonLot( pos);
        }
    }
}
