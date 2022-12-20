using Laurence.Game_utilities.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class EnemyHealth : MonoBehaviour, IDamagable
    {
        public EnemyData enemyData;
        [SerializeField] public int health;

        private void Start()
        {
            health = enemyData.health;
        }

        public void TakeDamage(int Damage)
        {
            if (health < 0)
                return;
            health -= Damage;
            if (health <= 0)
            {
                OnDeath();
            }
        }
        public  void OnDeath()
        {
            Destroy(transform.parent.gameObject, 0.1f);
        }
    }
}
