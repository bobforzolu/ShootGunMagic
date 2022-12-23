using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

namespace Laurence
{
    public class Dash : AbilityState
    {
        public Dash(PlayerController controller, Statemachine statemachine) : base(controller, statemachine)
        {
        }

        private float dashTime;
        private float canceltime;
        private bool CanDash;
        private float lastdashtime;

        private Vector2 DashDirection;
        public bool Attack;
        public bool isJumupInput;


        public override void Enter()
        {
            base.Enter();
            startTime = Time.time;
            canceltime = Time.time;
            DashDirection = Vector2.right * controller.core.movement.facingDirections;
            controller.animator.SetBool("dash", true);
        }

        public override void Exit()
        {
            base.Exit();
            controller.animator.SetBool("dash", false);
        }

        public override void Update()
        {
            base.Update();
            Attack = controller.input.isAttack;
            isJumupInput = controller.input.JumpInput;
            controller.core.movement.SetVelocity(controller.PlayerStats.dashVelocity, DashDirection);

            if (Time.time >= canceltime + controller.PlayerStats.dashInteruptTime && Attack && isGrounded)
            {
                controller.core.movement.SetVelocityX(0);
                statemachine.CangeState(controller.AttackState);

            }
            else if (Time.time >= canceltime + controller.PlayerStats.dashInteruptTime && isJumupInput && isGrounded)
            {
                controller.core.movement.SetVelocityX(0);
                statemachine.CangeState(controller.AttackState);

            }
            if (Time.time >= startTime + controller.PlayerStats.dashTime)
            {
                controller.core.movement.SetVelocityX(0);
                lastdashtime = Time.time;
                isAbilityFinish = true;
            }

        }

        public bool CheckIfCanDash()
        {
            return Time.time >= lastdashtime + controller.PlayerStats.dashCoolDown;
        }
    }
}
