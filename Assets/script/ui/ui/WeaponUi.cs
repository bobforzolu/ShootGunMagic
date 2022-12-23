using Laurence.script;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


namespace Laurence
{
    public class WeaponUi : MonoBehaviour
    {
        public VisualElement blaster;
        public VisualElement flamethrower;
        public VisualElement shotgun;
        private Text blasterAmmoAmount;
        private Text falmeAmmoAmount;
        private Text ShootGunAmmoAmount;

        public GunEventHandler gunEvent;



        public UIDocument playerui;

        // Start is called before the first frame update
        void Start()
        {
            var root = playerui.rootVisualElement;
            shotgun = root.Q<VisualElement>("shotgun");

            blaster = root.Q<VisualElement>("blaster");
            flamethrower = root.Q<VisualElement>("flame");


            gunEvent.OnAmmoUiUpdate += UpdateAmmo;
            UpdateAmmo(0);
        }
        private void Update()
        {
        }
        public void UpdateAmmo(int index)
        {
            ResetAmmo();
            if (index == 0)
            {
                blaster.style.backgroundColor = Color.blue;

            }
            else if (index == 2)
            {
                flamethrower.style.backgroundColor = Color.blue;
            }
            else if (index == 1)
            {
                shotgun.style.backgroundColor = Color.blue;
            }

        }
        private void ResetAmmo()
        {
            var root = playerui.rootVisualElement;

            blaster.style.backgroundColor = Color.white;


            shotgun.style.backgroundColor = Color.white;


            flamethrower.style.backgroundColor = Color.white;



        }
    }
}
