using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Laurence
{
    public class EnemyAnimationController : MonoBehaviour
    {
        public event Action OnAnimationFinish;
        // Start is called before the first frame update
        void Start()
        {
            OnAnimationFinish += transform.parent.GetComponent<EnemyController>().Isattacking;
        }

        // Update is called once per frame
       public void attackDone()
        {
            OnAnimationFinish?.Invoke();
        }
        public void AddMovement()
        {

        }
    }
}
