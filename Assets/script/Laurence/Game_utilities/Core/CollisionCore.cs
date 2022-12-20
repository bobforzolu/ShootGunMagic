using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Laurence;

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
        public void logicUpdate()
        {
        
        }

        public bool GroundCheck()
        {
            
            return Physics2D.OverlapCircle(GroudCheckPosition.position, playerData.GroundCheck_Radius, playerData.ground);
        }
       
    }
}
