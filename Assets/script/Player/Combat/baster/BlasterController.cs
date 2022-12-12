using Laurence.script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class BlasterController : MonoBehaviour
    {
        public GunEventHandler blasterEvent;
        private AmmoType currentAmmo;
        public AmmoType[] ammoTypes;
        public Transform FirePoint;
        public int index;
        
        private void OnEnable()
        {
            blasterEvent.OnShootTrigger += FireAmmo;
            blasterEvent.onAmmoSwithchRight += UpdateAmmo;
        }

        private void Start()
        {
            index = 0;
            currentAmmo = ammoTypes[index];
        }
        private void UpdateAmmo()
        {
            index++;
            if(index >= 3)
            {
                index = 0;
                Debug.Log(currentAmmo);

            }
            currentAmmo = ammoTypes[index];
            blasterEvent.UiUpaadtetrigger(index);

        }
        public void FireAmmo()
        {
            currentAmmo.IntantiateBullets(FirePoint);
        }

    }
}
