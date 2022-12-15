using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Laurence
{
    public class Playerdetection : MonoBehaviour
    {
        public int attackZone;
        public LayerMask playerlayer;
        public event Action<bool> OnPlayerFound;

        public delegate GameObject findMyPlayer(GameObject player);
        public findMyPlayer foundplayer;
        public void attackRange()
        {
         Collider2D j =Physics2D.OverlapCircle(transform.position, attackZone, playerlayer);
         
            if (j != null)
            {

                OnPlayerFound?.Invoke(true);
                 Debug.Log("gay");
            }
            else
            {
                OnPlayerFound?.Invoke(false);
                Debug.Log("fag");
            }




        }
        public Vector2 getplyer( GameObject player)
        {

            return new Vector2(player.transform.position.x, player.transform.position.y);
        }
        private void Update()
        {
            attackRange();
        }


        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, attackZone);

            

        }
    }
}
