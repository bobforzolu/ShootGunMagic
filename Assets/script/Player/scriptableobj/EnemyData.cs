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

    }
}
