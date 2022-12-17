using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    [CreateAssetMenu(fileName = "PlayerData", menuName ="data/Player Data")]
    public class PlayerData : ScriptableObject
    {
        [Header("health")]
        public int Maxhealth;
        public int currentHealth;
        [Header("Movestate")]
        public float movementvelocity = 10f;

        [Header("jumpSpeed")]
        public float JumpForce = 10f;

        [Header("GroundCheck")]
        public float GroundCheck_Radius = 1f;
        public LayerMask ground;

        [Header("in Air State ")]
        public float variablesJumpHeight = 0.4f;

        public int FacingDirection;

        [Header("attack")]
        public int damage2 = 5;
        public int damage1 = 3;

    }
}
