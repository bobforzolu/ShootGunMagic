using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence.Game_utilities.Enemy
{

    public class LargEnemys : EnemyType
    {
        public EnemyData enemyData;
        public LargEnemys(int health) : base(health)
        {
            health = enemyData.health;
        }

        public override void TakeDamage(float Damage)
        {
            base.TakeDamage(Damage);
        }
    }
}
