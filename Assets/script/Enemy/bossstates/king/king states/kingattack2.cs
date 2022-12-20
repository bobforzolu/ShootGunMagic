using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class kingattack2 : StateMachineBehaviour
    {
        public Kingscriptableobject king;   
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            king.AnimationDone = false;
            king.CanFlip = true;
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            king.CanFlip = false;
            if(king.AnimationDone)
             animator.SetTrigger("idle");
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            
        }

    }
}
