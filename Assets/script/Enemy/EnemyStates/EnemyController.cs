using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

namespace Laurence
{
    public class EnemyController : MonoBehaviour
    {
        // Start is called before the first frame update
        public Core core;
        public EnemyData data;
        public SpriteRenderer sprite;
        public Animator animator;
        public Statemachine statemachine { get; private set; }

        [HideInInspector]public Transform Playerlocation;

        public EnemyPatrol_state patrol_State { get; private set; }
        public EnemyAttack_State patrol_Attack { get; private set; }
        public Enemy_Idle _Enemy_idle { get; private set; }



        public Transform[] PatrolPoint;

        private void Awake()
        {


        }
        private void OnEnable()
        {
           // statemachine.Intialize(patrol_State);

        }

        void Start()
        {
            statemachine = new Statemachine();
            patrol_State = new EnemyPatrol_state(data, statemachine, this );
            patrol_Attack = new EnemyAttack_State(data, statemachine, this);
            _Enemy_idle = new Enemy_Idle(data, statemachine, this);
            animator = GetComponentInChildren<Animator>();
            core = GetComponentInChildren<Core>();
            sprite = GetComponentInChildren<SpriteRenderer>();
            statemachine.Intialize(patrol_State);
        }

        // Update is called once per frame
        void Update()
        {
            PlayerEnterAttackRange(transform.parent.GetComponentInParent<Playerdetection>().attackRange());
            statemachine.CurrentEnemy.Update();
        }
        private void FixedUpdate()
        {
            core.LogicUpdate();
            statemachine.CurrentEnemy.FixedUpdate();
        }

        // calls if player has entered the attack Range
        public void PlayerEnterAttackRange(bool found)
        {
            if(found)
            {
              patrol_State.EnemyFound = true;
                patrol_Attack.EnemyFound = true;
                Debug.Log("truw");
                Playerlocation = FindObjectOfType<PlayerController>().transform;

            }
            else
            {
                patrol_State.EnemyFound = false;
                patrol_Attack.EnemyFound = false;
            }
              
        }
        public void Isattacking() => patrol_Attack.AnimationFinishTrigger();
        
        

    }
}
