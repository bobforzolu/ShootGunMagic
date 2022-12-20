using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class KingIdle : StateMachineBehaviour
    {
        public Kingscriptableobject king;
        private float idleTime;

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            idleTime = Time.time;
            king.CanFlip = true;
            if(king.Energy >= king.MaxEnergy)
            {
                king.Energy = 0;
                king.relaxtime = 3f;

            }
            else
            {
                king.relaxtime = 1f;
            }
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (king.phase1)
            {
                 if(Time.time >= idleTime + king.relaxtime)
                 {
                                animator.SetTrigger("walk");
                 }
            }else if (king.phase2)
            {

            }
           
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            king.CanFlip = false;
            animator.ResetTrigger("walk");


        }


    }
}
