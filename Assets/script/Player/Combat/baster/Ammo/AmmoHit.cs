using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class AmmoHit : MonoBehaviour
    {
        public float lifetime;
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            Destroy(this.gameObject, lifetime);
        }
    }
}
