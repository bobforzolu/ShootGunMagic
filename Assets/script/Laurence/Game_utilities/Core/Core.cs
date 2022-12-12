using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence.Game_utilities.Core
{
    public class Core : MonoBehaviour
    {
        public MovementCore movement { get; private set; }
        public CollisionCore collison_Sense { get; private set; }
        public AttackCore attack { get; private set; }

        // public Interactions Interactions{get; private set;}

        private void Awake()
        {
            movement = GetComponentInChildren<MovementCore>();
            collison_Sense = GetComponentInChildren<CollisionCore>();
            attack = GetComponentInChildren<AttackCore>();

           
            
        }
        public void LogicUpdate()
        {
            movement.LogicUpdate();
            collison_Sense.logicUpdate();
        }
        public void PhysicsUpdate()
        {

        }
    }
}
