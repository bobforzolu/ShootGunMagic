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
        public samuriSo samuri;
        public int woldspeed;
        
        private void Start()
        {
            core = GetComponentInChildren<Core>();
            
        }
        public void AddforceAttack1()
        {
            core.movement.SetVelocityX(core.movement.facingDirections * king.hit1movespeed);
        }
        public void AddforceAttack2()
        {
            core.movement.SetVelocityX(core.movement.facingDirections * king.hit2movespeed);
        }
      
        public void AddSamuriAttack1F()
        {
            core.movement.SetVelocityX(core.movement.facingDirections * samuri.attack1Range);
        }
        public void ResetSpeed()
        {
            core.movement.SetVelocityX(0);
            core.movement.SetVelocityY(0);

        }
        public void CanDamage()
        {
            core.attack.CanDamage(true);
        }
        public void DamageEnemy(int damage)
        {
             core.attack.Damage(damage);
            
        }
        public void AddWolfAttack1F()
        {
            core.movement.SetVelocityX(core.movement.facingDirections * (woldspeed));
            core.movement.SetVelocityY( woldspeed);

        }
        private void Teleport() => king.Teleporttrigger();
        
    }
}
