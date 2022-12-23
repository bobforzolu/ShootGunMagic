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
        public float walkTime;
        public float idleTime;
        public int Energy;
        public int MaxEnergy;

        public bool canflip;

        public float distanceToTarger;
        public float attackRange;

        public float attackTimer;
        public float attackcooldown;
        public bool canAttack;


        public float attack1Range;
    }
}
