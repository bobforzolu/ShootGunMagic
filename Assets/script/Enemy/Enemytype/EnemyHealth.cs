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
                OnDeath();
            }
        }
        public  void OnDeath()
        {

            if (transform.parent == null)
            {
             DropLot(gameObject.transform);
            enemyData.health = enemyData.maxhealth;
                gameObject.SetActive(false);

            }
            else
            {
                enemyData.health = enemyData.maxhealth;
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
