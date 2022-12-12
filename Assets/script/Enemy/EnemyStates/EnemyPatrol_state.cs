using Laurence.Game_utilities;
using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class EnemyPatrol_state : EnemyState
    {
        public int _CurrentWaypoint;
        public bool _Waiting;
        public float startwaittime;
        
        public EnemyPatrol_state(EnemyData Data, Statemachine statemachine, EnemyController controller) : base(Data, statemachine, controller)
        {
        }

        public override void Enter()
        {
            base.Enter();
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

            Transform wp = controller.PatrolPoint[_CurrentWaypoint];
            Debug.Log(wp);
            if(Vector2.Distance(controller.transform.position, wp.position) < 0.11f)
            {
               
                
                controller.transform.position = wp.position;
                startwaittime = Time.time;
                _Waiting = true;
                _CurrentWaypoint = (_CurrentWaypoint + 1) % controller.PatrolPoint.Length;
            }
            else
            {
                controller.transform.position = Vector3.MoveTowards(controller.transform.position, wp.position, data.speed * Time.deltaTime);
            }
                
        }
    }
}
