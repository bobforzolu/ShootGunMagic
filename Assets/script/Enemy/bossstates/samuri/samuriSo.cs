using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{

    [CreateAssetMenu(fileName = "samuri data", menuName = "Boss Data / samuri data")]

    public class samuriSo : ScriptableObject
    {
        [Header("Speed")]
        public int speed;



        public bool canflip;

        public float distanceToTarger;
    }
}
