using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    [CreateAssetMenu(fileName = "stats",menuName ="status")]
    public class Stats : ScriptableObject
    {
      
        [Header("damage")]
        public float minDamage;
        public float maxDamage;

        [Header("movement")]
        public float speed = 5;
        public float jumpVelocity = 5;






    }
}
