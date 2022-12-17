using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence.Game_utilities.Enemy
{

    public class LargEnemys : EnemyType
    {
        public EnemyData enemyData;
      

        public  void TakeDamage(int Damage)
        {
            base.TakeDamage(Damage);
        }
    }
}
