using Laurence.Game_utilities;
using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Laurence
{
    public class EnemyPatrol_state : EnemyState
    {
        public int _CurrentWaypoint;
        public bool _Waiting;
        public float startwaittime;
        public bool EnemyFound;
        public bool canFlip;
        private float currentRotation;

        public EnemyPatrol_state(EnemyData Data, Statemachine statemachine, EnemyController controller) : base(Data, statemachine, controller)
        {
        }

        public override void Enter()
        {
            base.Enter();
            controller.sprite.color = Color.green;
            controller.animator.SetBool("run", true);

        }

        public override void Exit()
        {
            base.Exit();
        }

        public  override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override void Update()
        {
            base.Update();
            
            if (_Waiting)
            {
                if (Time.time <= startwaittime + data.waitTime)
                    return;
               
                _Waiting = false;
                
                        
             }
            
            canFlip = true;

            Transform wp = controller.PatrolPoint[_CurrentWaypoint];
            
            if(Vector2.Distance(controller.transform.position, wp.position) < 0.21f)
            {
                controller.animator.SetBool("run", false);

                controller.animator.SetBool("idle", true);

                canFlip = true;
                controller.transform.position = wp.position;
                startwaittime = Time.time;
                _Waiting = true;
                _CurrentWaypoint = (_CurrentWaypoint + 1) % controller.PatrolPoint.Length;
            }
            else
            {
                controller.animator.SetBool("idle", false);
                controller.animator.SetBool("run", true);

                controller.rb.MovePosition (  Vector3.MoveTowards(controller.transform.position, wp.position, data.speed * Time.deltaTime));

                controller.core.movement.CheckIfShouldFlip(playerfacingdir(controller.transform.position, wp.position));




            }

            if (EnemyFound)
            {
                statemachine.CangeState(controller.patrol_Attack);
            }
                
        }
    }
}
