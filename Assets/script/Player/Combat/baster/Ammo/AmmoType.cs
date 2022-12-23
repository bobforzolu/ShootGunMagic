using Laurence.script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    [CreateAssetMenu(fileName ="ammotype",menuName ="ammo/ammotype")]
    public  class AmmoType : ScriptableObject
    {
        public GameObject ammoType;
        public GameObject AmmoHitEffect;
        public float ammoAmount;
        public int MaxAmmo;
        public float speed;
        public int Damage;
        public float ammoRecovery;
        public GunEventHandler gun;

       public void IntantiateBullets(Transform instanitatePoint)
        {
            if (ammoAmount < 1)
                return;
            ammoAmount -= 1;
            Instantiate(ammoType, instanitatePoint.transform.position, Quaternion.identity);

            
        }
        

      

        public void RecoverAmmo()
        {
            ammoAmount += ammoRecovery;
        }

    }
}
