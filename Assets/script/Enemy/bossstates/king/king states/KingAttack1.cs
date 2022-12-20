using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class KingAttack1 : StateMachineBehaviour
    {
        public Kingscriptableobject king;

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            king.AnimationDone = false;
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if(king.Energy <= king.MaxEnergy && king.AnimationDone)
            {
             animator.SetTrigger("attack2");

            }
           
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
                        king.Energy++;

        }


    }
}
