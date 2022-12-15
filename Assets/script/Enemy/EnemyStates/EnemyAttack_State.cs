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
        public float count;
        public bool isattacking;



        public EnemyAttack_State(EnemyData data, Statemachine statemachine, EnemyController controller) : base(data, statemachine, controller)
        {
        }


        public override void AnimationFinishTrigger()
        {
            base.AnimationFinishTrigger();
        }

        public override void Enter()
        {
            base.Enter();

                attackTime = Time.time;
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

            Transform player = controller.Playerlocation;
            if(Vector2.Distance(controller.transform.position, player.position) >= data.Attackrange)
            {
                if (!isattacking)
                {
                    controller.rb.MovePosition( Vector2.MoveTowards(controller.transform.position, player.position, data.speed *Time.deltaTime));
                    controller.core.movement.CheckIfShouldFlip(playerfacingdir(controller.transform.position, player.position));
                    controller.animator.SetBool("attack", false);
                    controller.animator.SetBool("idle", false);

                    controller.animator.SetBool("run", true);

                }
            }
            else{
                // attack
                if (counter() <= 0)
                {
                    controller.animator.SetBool("run", false);
                    controller.animator.SetBool("idle", false);

                    controller.animator.SetBool("attack", true);
                   
                    count = 3;

                }
                else
                {
                    isattacking = false;
                    controller.sprite.color = Color.white;

                    attackTime = Time.time;
                    controller.animator.SetBool("attack", false);
                    controller.animator.SetBool("run", false);

                    controller.animator.SetBool("idle", true);
                    if(count < 0.7f)
                    isattacking = true;
                        controller.sprite.color = Color.red;

                }
            }
            if (!EnemyFound)
            {
                statemachine.CangeState(controller.patrol_State);
            }
        }

        public float counter()
        {
            count -= Time.deltaTime * 1;

            return count;


        }
     
       
    }
}
