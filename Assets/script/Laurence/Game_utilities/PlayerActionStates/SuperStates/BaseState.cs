using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence.Game_utilities
{
    public abstract class BaseState 
    {
        protected BaseState()
        {
        }

        protected virtual void Enter()
        {

        }
        protected virtual void Update()
        {

        }
        protected virtual void Exit()
        {

        }
        public virtual void AnimationFinishTrigger()
        {

        }
    }

}
