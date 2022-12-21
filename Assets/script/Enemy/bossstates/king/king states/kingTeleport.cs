using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class kingTeleport : StateMachineBehaviour
    {
        public Kingscriptableobject king;
        private Rigidbody2D Rb2d;
        public int i;
        public AnimationPatterns patterns;


        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            king.OnTeleport += TeleportLocation;
            Rb2d = animator.GetComponent<Rigidbody2D>();
            king.AnimationDone = false;
            patterns = animator.GetComponent<AnimationPatterns>();
            king.Energy++;

        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
           
            
             if (king.Energy>= king.MaxEnergy && king.AnimationDone)
            {
                animator.SetTrigger("idle");
            }
            else if(king.AnimationDone)
            {
                animator.SetTrigger(patterns.teleportRoulet());

            }
           
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            
        }
        public void TeleportLocation()
        {
                Rb2d.transform.position = king.Playerpos;
            /**if(i == 0)
            {

                
            }
            else if(i ==1)
            {
                Rb2d.transform.position = king.restlocation[0];

            }
            else if(i == 2)
            {
                Rb2d.transform.position = king.restlocation[1];

            }
            i++;
            if (i >= 3)
                i = 0;**/
        }

       
    }
}
