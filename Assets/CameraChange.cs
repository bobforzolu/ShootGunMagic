using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class CameraChange : MonoBehaviour
    {
        public CinemachineVirtualCamera maincam;
        public CinemachineVirtualCamera bosscam;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                maincam.Priority= 0;
                bosscam.Priority= 1;
                
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }
    }
}
