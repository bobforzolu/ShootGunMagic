using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class SamuriIdle : StateMachineBehaviour
    {
        private float idleTimer;
        public samuriSo samuri;
        private Core core;
       
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            core = animator.GetComponentInChildren<Core>();
            idleTimer = Time.time;
            if(samuri.Energy >= samuri.MaxEnergy)
            {
                samuri.Energy = 0;
            }
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            samuri.canflip = true;
            if(Time.time >= idleTimer + samuri.idleTime)
            {
                animator.SetTrigger("move");
            }
            
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            samuri.canflip = false;

        }

    }
}
