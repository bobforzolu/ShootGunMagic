using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Laurence
{
    public class Healthbar : MonoBehaviour
    {

        public Slider uiHealth;
        public PlayerData data;

        private void Start()
        {
            SetHealth();
        }
       

        

        private void Update()
        {
            uiHealth.value = data.currentHealth;
        }
        public void SetHealth()
        {
            uiHealth.maxValue = data.Maxhealth;
            data.currentHealth = data.Maxhealth;
            uiHealth.value = uiHealth.maxValue;
        }

    }
}
