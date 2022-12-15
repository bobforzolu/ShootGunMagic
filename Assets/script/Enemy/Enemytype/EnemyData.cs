using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    [CreateAssetMenu(fileName = "EnemyData", menuName = "data/Enemy Data")]

    public class EnemyData : ScriptableObject
    {
        [Header("Stats")]
        public int health;
        public float Attackrange;
        public float speed;
        public float attackSpeed;

        [Header("patrol")]
        public float detectledge;
        public float detectwall;
        public LayerMask layerMask;
        public float waitTime = 1f;

    }
}
