using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class LootBag : MonoBehaviour
    {
        public Loot loot; 
        private void Start()
        {
        }

        private Loot GetDropChance()
        {

            int randomNumber = Random.Range(1, 101);

           
            if(randomNumber <= loot.dropChance)
            {
                    return loot;
                
            }
            else
                return null;


        }
        private void OnDestroy()
        {

        }
        public void SummonLot(Transform position)
        {
            if(GetDropChance() != null)
            {
                Instantiate(GetDropChance().Health, position.position, Quaternion.identity);
            }
            else
            {
                return;
            }
        }
    }
}
