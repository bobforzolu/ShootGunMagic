using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class Samurirun : StateMachineBehaviour
    {
        private float runTimer;
        public samuriSo samuri;
        private Core core;

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            core = animator.GetComponentInChildren<Core>();
            runTimer = Time.time;
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (Time.time >= runTimer + samuri.walkTime)
            {
                core.movement.SetVelocityX(samuri.speed);
                if(samuri.distanceToTarger <= samuri.attackRange)
                {
                 animator.SetTrigger("attack1");

                }
            }
            else
            {
                animator.SetTrigger("walk");
            }
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }
    }
}
