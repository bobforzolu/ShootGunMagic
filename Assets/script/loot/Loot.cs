using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    [CreateAssetMenu(menuName = " loot", fileName = "loot / loot item")]

    public class Loot : ScriptableObject
    {
        public GameObject Health;
        public int dropChance;
       
    }
}
