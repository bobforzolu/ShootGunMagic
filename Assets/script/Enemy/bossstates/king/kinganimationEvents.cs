using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Laurence
{
    public class kinganimationEvents : MonoBehaviour
    {
        private Core core;
        public Kingscriptableobject king;
        
        private void Start()
        {
            core = GetComponentInChildren<Core>();
            
        }
        public void AddforceAttack1()
        {
            core.movement.RB.AddForce(Vector2.right * core.movement.facingDirections * king.hit1movespeed, ForceMode2D.Impulse);
        }
        public void AddforceAttack2()
        {
            core.movement.RB.AddForce(Vector2.right * core.movement.facingDirections * king.hit2movespeed, ForceMode2D.Impulse);
        }
        private void Teleport() => king.Teleporttrigger();
        
    }
}
