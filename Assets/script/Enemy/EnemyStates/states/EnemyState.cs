using Laurence.Game_utilities;
using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class EnemyState : BaseState
    {
       protected EnemyData data;
       protected Statemachine statemachine;
       protected EnemyController controller;

        public EnemyState(EnemyData data, Statemachine statemachine, EnemyController controller)
        {
            this.data = data;
            this.controller = controller;
            this.statemachine = statemachine;
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
        protected int playerfacingdir(Vector2 me, Vector2 them)
        {
            if (me.x < them.x)
            {
                return 1;
            }
            else
                return -1;
        }
    }
}
