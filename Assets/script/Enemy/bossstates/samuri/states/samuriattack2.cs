using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class samuriattack2 : StateMachineBehaviour
    {
        public samuriSo samuri;

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            samuri.Energy++;
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animator.SetTrigger("idle");

        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }
    }
}
