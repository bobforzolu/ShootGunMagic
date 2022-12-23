using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class Kingwalk : StateMachineBehaviour
    {
        public Kingscriptableobject king;
        private float walkTime;
        private Core core;
        public AnimationPatterns patterns;

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            patterns = animator.GetComponent<AnimationPatterns>();

            core = animator.GetComponentInChildren<Core>();
            king.CanFlip = true;
            walkTime = Time.time;
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (king.phase1)
            {
                if(king.distanceToTarger > king.range)
                {
                    core.movement.SetVelocityX(core.movement.facingDirections * king.speed);
                }else if(king.distanceToTarger <= king.range && king.Energy <= 5)
                {
                    animator.SetTrigger("attack1");

                }

                else if(Time.time >= walkTime + king.walkDuration)
                {
                    animator.SetTrigger("idle");
                }

            }else if (king.phase2)
            {
                if (king.distanceToTarger > king.range)
                {
                    core.movement.RB.MovePosition(Vector2.MoveTowards(new Vector3(animator.transform.position.x, animator.transform.position.y), king.Playerpos, king.speed * Time.deltaTime));

                }
                if (Time.time >= walkTime + king.walkDuration)
                {
                    animator.SetTrigger(patterns.WalkRoulet());
                }
            }
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animator.ResetTrigger("walk");
            core.movement.SetVelocityX(0);

            king.CanFlip = false;

        }
        public void RandomState()
        {

        }
        

      
    }
}
