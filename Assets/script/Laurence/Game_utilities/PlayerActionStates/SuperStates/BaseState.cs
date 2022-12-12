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

        public virtual void Enter()
        {

        }
        public virtual void Update()
        {

        }
        public virtual void FixedUpdate()
        {

        }
        public virtual void Exit()
        {

        }
        public virtual void AnimationFinishTrigger()
        {

        }
    }

}
