using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class KingAttack1 : StateMachineBehaviour
    {
        public Kingscriptableobject king;
        private Core core;


        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            king.AnimationDone = false;
            core = animator.GetComponentInChildren<Core>();
            king.CanFlip = true;
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            king.CanFlip = false;
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
