using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class PlayerHealth : MonoBehaviour,IDamagable
    {
        public PlayerData player;
        public void TakeDamage(int Damage)
        {
            player.currentHealth -= Damage;
        }
        public void recoverhealth(int health)
        {
            player.currentHealth += Mathf.Clamp(health, 0, player.Maxhealth);
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
