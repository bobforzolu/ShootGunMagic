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
                samuri.canflip = true;
            if (Time.time >= runTimer + samuri.walkTime)
            {
                animator.SetTrigger("idle");

            }
            if(samuri.distanceToTarger >= samuri.attackRange)
            {
                core.movement.SetVelocityX(samuri.speed * core.movement.facingDirections) ;

            }



             if (samuri.distanceToTarger <= samuri.attackRange && samuri.Energy <= samuri.MaxEnergy)
            {
                animator.SetTrigger("attack1");

            }
           
            
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            core.movement.SetVelocityX(0);
            samuri.canflip = false;


        }
    }
}
