using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class samuriattack1 : StateMachineBehaviour
    {
        public samuriSo samuri;
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            samuri.Energy++;
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (samuri.Energy <= samuri.MaxEnergy)
                animator.SetTrigger("attack2");
            else
                animator.SetTrigger("idle");
                    
          
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }
    }
}
