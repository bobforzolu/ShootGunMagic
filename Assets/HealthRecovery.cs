using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class HealthRecovery : MonoBehaviour
    {
        public int health = 10;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.GetComponent<PlayerHealth>().recoverhealth(health);
                Destroy(gameObject);
            }   
        }
    }
}
