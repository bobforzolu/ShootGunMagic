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

        public Transform detectledge;
        public Transform detectwall;

        public EnemyData enemyData;

        protected override void Awake()
        {
            base.Awake();

        }
        public void logicUpdate()
        {
            FindWall();
            FindLedge();
        }

        public bool GroundCheck()
        {
            
            return Physics2D.OverlapCircle(GroudCheckPosition.position, playerData.GroundCheck_Radius, playerData.ground);
        }
        public bool FindLedge()
        {
            return Physics2D.Raycast(detectledge.transform.position, Vector2.down, enemyData.detectledge, enemyData.layerMask);
        }
        public bool FindWall()
        {
            
            return  Physics2D.Raycast(detectledge.transform.position, Vector2.right, enemyData.detectwall, enemyData.layerMask);
        }
        


        public void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(detectledge.transform.position, Vector2.down * enemyData.detectledge);
            Gizmos.DrawRay(detectwall.transform.position, Vector2.right * enemyData.detectwall);
            

            Gizmos.DrawWireSphere(GroudCheckPosition.position, playerData.GroundCheck_Radius);
          
        }
    }
}
