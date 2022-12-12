using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class EnemyController : MonoBehaviour
    {
        // Start is called before the first frame update
        public Core core;
        public EnemyData data;
        public Statemachine statemachine { get; private set; }

        public EnemyPatrol_state patrol_State { get; private set; }

        public Transform[] PatrolPoint;

        private void Awake()
        {
            statemachine = new Statemachine();
            patrol_State = new EnemyPatrol_state(data, statemachine, this );

        }

        void Start()
        {
            statemachine.Intialize(patrol_State);
        }

        // Update is called once per frame
        void Update()
        {
            core.LogicUpdate();
            statemachine.CurrentEnemy.Update();
        }
        private void FixedUpdate()
        {
            statemachine.CurrentEnemy.FixedUpdate();
        }
    }
}
