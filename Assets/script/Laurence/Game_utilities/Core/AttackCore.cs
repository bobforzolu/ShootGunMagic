using Laurence.Game_utilities.Core;
using Laurence.script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace Laurence
{
    public class AttackCore : CoreComponent
    {
        public List<IDamagable> DamageEnemy = new List<IDamagable>();
        public bool CanHit = true;
        public GunEventHandler gun;
        protected override void Awake()
        {
            base.Awake();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (gameObject.transform.root.CompareTag("Player"))
            {
                Debug.Log("hi");
                if(collision.CompareTag("Enemy") || collision.CompareTag("King"))
                {
                    AddDectetedEnemy(collision);

                }

            }
            else
            {
                if (collision.CompareTag("Player"))
                {
                    AddDectetedEnemy(collision);

                }
            }
            
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            CanDamage(true);
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
            if (!CanHit)
                return;
            for (int i = 0; i < DamageEnemy.Count; i++)
            {
                if (transform.parent.root.CompareTag("Player"))
                {
                    
                    gun.RecoveryHitTrigger();
                }
                DamageEnemy[i].TakeDamage(damage);
                if (transform.parent.root.CompareTag("Enemy")|| transform.parent.root.CompareTag("King"))
                {
                    CanDamage(false);
                }
            }
            

        }
        public bool CanDamage( bool  a)
        {  
           CanHit = a;
            return a;
        }

    }
}
