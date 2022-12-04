using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence.Game_utilities.Core
{
    public class CollisionCore : CoreComponent
    {
        [SerializeField]
        public Transform GroudCheckPosition;
        public PlayerData playerData;

        protected override void Awake()
        {
            base.Awake();

        }

        public bool GroundCheck()
        {
            return Physics2D.OverlapCircle(GroudCheckPosition.position, playerData.GroundCheck_Radius, playerData.ground);
        }


        public void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(GroudCheckPosition.position, playerData.GroundCheck_Radius);
        }
    }
}
