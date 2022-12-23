using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Laurence
{
    public class MPScript : MonoBehaviour
    {
        public AmmoType shotgun;
        public Slider slider;
        void Start()
        {
            SetUpAmmo();
        }
        public void SetUpAmmo(){

            slider.maxValue = shotgun.MaxAmmo;
            slider.value = shotgun.ammoAmount;
            shotgun.ammoAmount = shotgun.MaxAmmo;
        }
        // Update is called once per frame
        void Update()
        {
            slider.value = shotgun.ammoAmount;
        }
    }
}
