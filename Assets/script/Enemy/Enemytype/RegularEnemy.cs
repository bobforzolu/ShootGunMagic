using Laurence.Game_utilities.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class RegularEnemy : EnemyType
    {
        public EnemyData enemyData;
        public RegularEnemy(int health) : base(health)
        {
            health = enemyData.health;
        }

        public override void TakeDamage(float Damage)
        {
            base.TakeDamage(Damage);
        }
    }
}
