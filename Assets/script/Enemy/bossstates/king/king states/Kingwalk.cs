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
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            core = animator.GetComponentInChildren<Core>();
            king.CanFlip = true;
            walkTime = Time.time;
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if(king.distanceToTarger > king.range)
            {
                core.movement.RB.MovePosition(Vector2.MoveTowards(new Vector3(animator.transform.position.x, animator.transform.position.y), king.Traget2 , king.speed * Time.deltaTime));

            }else if(king.distanceToTarger <= king.range && king.Energy <= 5)
            {
                animator.SetTrigger("attack1");

            }

            else if(Time.time >= walkTime + king.walkDuration)
            {
                animator.SetTrigger("idle");
            }
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animator.ResetTrigger("walk");
            king.CanFlip = false;

        }
        public void RandomState()
        {

        }
        

      
    }
}
