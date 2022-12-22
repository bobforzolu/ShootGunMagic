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
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if(Time.time >= idleTimer + samuri.idleTime)
            {
                animator.SetTrigger("walk");
            }
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            
        }

    }
}
