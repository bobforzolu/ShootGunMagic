using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Laurence
{
    public class Healthbar : MonoBehaviour
    {

        public ProgressBar health;
        public UIDocument playerui;
        public int currentHealth;

        private void Start()
        {
            UpdateHealth();
        }

        private void UpdateHealth()
        {
            var root = playerui.rootVisualElement;
            health = root.Q<ProgressBar>("health");
            health.value = currentHealth;
        }

        private void Update()
        {
            UpdateHealth();
        }


    }
}
