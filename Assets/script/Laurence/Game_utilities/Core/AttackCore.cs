using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace Laurence
{
    public class AttackCore : CoreComponent
    {
        public List<IDamagable> DamageEnemy = new List<IDamagable>();
        protected override void Awake()
        {
            base.Awake();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Enemy") || collision.CompareTag("King"))
                AddDectetedEnemy(collision);
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            RemoveDectetedEnemy(collision);
        }
        public void AddDectetedEnemy(Collider2D target)
        {
            IDamagable[] enemys = target.GetComponentsInChildren<IDamagable>();
            foreach (IDamagable enemy in enemys)
            {
                Debug.Log(enemy);
                DamageEnemy.Add(enemy);
            }
        }
        public void RemoveDectetedEnemy(Collider2D target)
        {
            IDamagable[] enemys = target.GetComponents<IDamagable>();
            
            if(enemys != null)
            {
                DamageEnemy.Clear();
            }


        }
        public void Damage(int damage)
        {
            for (int i = 0; i < DamageEnemy.Count; i++)
            {
                DamageEnemy[i].TakeDamage(damage);
            }
        }

    }
}
