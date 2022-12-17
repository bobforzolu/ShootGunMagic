using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Laurence
{
    public class EnemyAttack_State : EnemyState
    {

        public bool EnemyFound;
        public float attackTime;
        public float patroltime;
        public bool _CanAttack;
        public bool Isattacking;


        public EnemyAttack_State(EnemyData data, Statemachine statemachine, EnemyController controller) : base(data, statemachine, controller)
        {
        }


        public override void AnimationFinishTrigger()
        {
            base.AnimationFinishTrigger();
            Isattacking = false;
        }

        public override void Enter()
        {
            base.Enter();

        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override void Update()
        {
            base.Update();
            if (!EnemyFound)
            {
                controller.animator.SetBool("run", false);
                controller.animator.SetBool("attack", false);
                controller.animator.SetBool("idle", true);

            }
            if (!EnemyFound && canPatrol())
            {
                statemachine.CangeState(controller.patrol_State);
            }

            Transform player = controller.Playerlocation;
            controller.core.movement.CheckIfShouldFlip(playerfacingdir(controller.transform.position, player.position));
            if (Vector2.Distance(controller.transform.position, player.position) <= data.Attackrange && Canattack())
            {
                Isattacking = true;
                attackTime = Time.time;
                controller.animator.SetBool("run", false);
                controller.animator.SetBool("idle", false);
                controller.animator.SetBool("attack", true);

            }else if (Vector2.Distance(controller.transform.position, player.position) <= data.Attackrange && !Canattack() && !Isattacking)
            {
                patroltime = Time.time;
                controller.animator.SetBool("run", false);
                controller.animator.SetBool("attack", false);
                controller.animator.SetBool("idle", true);
            }
            else if(canPatrol() && !Isattacking )
            {
                controller.animator.SetBool("attack", false);

                controller.animator.SetBool("run", false);
                controller.animator.SetBool("idle", true);
                statemachine.CangeState(controller.patrol_State);
            }
            


        }
        public bool Canattack()
        {
            return Time.time >= attackTime + data.attackSpeed;
        }
        public bool canPatrol()
        {
            return Time.time >= patroltime + 1.5f;
        }
      

      
     
       
    }
}
