using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class LootBag : MonoBehaviour
    {
        public List<Loot> loot = new List<Loot>();
        public LootEvent DropLot;
        private void Start()
        {
            DropLot.OnDropLoot += SummonLot ;
        }

        private Loot GetDropChance()
        {

            int randomNumber = Random.Range(1, 101);
            List<Loot> possibleDrop = new List<Loot>();

            foreach (Loot item in loot)
            {
                if(randomNumber <= item.dropChance)
                {
                    possibleDrop.Add(item);
                   
                }
            }
            if(possibleDrop.Count > 0)
            {
                Loot droppedItem = possibleDrop[0];
                return droppedItem;
            }

            return null;

        }
        public void SummonLot(Vector2 position)
        {
            if(GetDropChance() != null)
            {
                Instantiate(GetDropChance(), position, Quaternion.identity);
            }
        }
    }
}
