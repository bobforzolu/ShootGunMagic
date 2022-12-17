using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class Enemy_Idle : EnemyState
    {
        public Enemy_Idle(EnemyData data, Statemachine statemachine, EnemyController controller) : base(data, statemachine, controller)
        {
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
