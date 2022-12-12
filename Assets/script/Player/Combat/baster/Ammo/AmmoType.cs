using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    [CreateAssetMenu(fileName ="ammotype",menuName ="ammo/ammotype")]
    public  class AmmoType : ScriptableObject
    {
        public GameObject Ammo;
        public GameObject AmmoHitEffect;
        public int ammoAmount;
        public float speed;
        public int Damage;

       public void IntantiateBullets(Transform instanitatePoint)
        {
           
               Instantiate(Ammo, instanitatePoint.transform.position, Quaternion.identity);

            
        }

      

        public void DeleteAmmo()
        {

        }

    }
}
