using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence.Game_utilities.Core
{
    public class MovementCore : CoreComponent
    {
        public Rigidbody2D RB { get; private set; }
        private Vector2 workplace;
        public int facingDirections { get; private set; }
        public Vector2 CurrentVelocity { get; private set; }


        protected override void Awake()
        {
            base.Awake();
            RB = GetComponentInParent<Rigidbody2D>();
            facingDirections = 1;
        }
        public void LogicUpdate()
        {
            CurrentVelocity = RB.velocity;

        }
        public void SetVelocityX(float velocity)
        {
            workplace.Set(velocity, CurrentVelocity.y);
            RB.velocity = workplace;
            CurrentVelocity = workplace;
        }
        public void SetVelocityY(float velocity)
        {
            workplace.Set(CurrentVelocity.x, velocity);
            RB.velocity = workplace;
            CurrentVelocity = workplace;
        }

        public void SetVelocity(float velocity, Vector2 Direction)
        {
            workplace = Direction * velocity;

            RB.velocity = workplace;
            CurrentVelocity = workplace;
        }
        public void SetVelocity(Vector2 velocity, Vector2 Direction)
        {
            workplace = Direction * velocity;
            RB.velocity = workplace;
            CurrentVelocity = workplace;
        }
        public Vector3 CheckIfShouldFlip(int XInput)
        {
            if (XInput != 0 && XInput != facingDirections)
            {
                return Flip();
            }
            return new Vector3(0, 0, 0);
        }



        public Vector3 Flip()
        {
            facingDirections *= -1;
            Vector3 rotation = new Vector3(0.0f, 180.0f, 0f);
            RB.transform.Rotate(0.0f, 180f, 0.0f);
            return rotation;
        }
       

    }
}
