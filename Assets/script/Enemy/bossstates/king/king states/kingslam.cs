using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class kingslam : StateMachineBehaviour
    {
        public Kingscriptableobject king;
        public AnimationPatterns patterns;


        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            patterns = animator.GetComponent<AnimationPatterns>();

            king.AnimationDone = false;
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if(king.AnimationDone)
                 animator.SetTrigger(patterns.SmashRoulet());
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            
        }

    }
}
