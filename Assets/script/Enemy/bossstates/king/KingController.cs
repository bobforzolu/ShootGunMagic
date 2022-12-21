using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class KingController : MonoBehaviour
    {
        public Kingscriptableobject kingdata;
        public EnemyData enemyData;
        private GameObject _Player;
        private GameObject _King;
        private SpriteRenderer sprite;

        public Transform[] restpoints;


        public Core core { get; private set; }

        private void Start()
        {
            sprite = GetComponent<SpriteRenderer>();
            _Player = GameObject.FindGameObjectWithTag("Player");
            _King = GameObject.FindGameObjectWithTag("King");
            core = GetComponentInChildren<Core>();
           kingdata.restlocation[0] = restpoints[0].position;
           kingdata.restlocation[1] = restpoints[1].position;



        }
        public void Update()
        {
            kingdata.distanceToTarger = Vector2.Distance(_King.transform.position, _Player.transform.position);
            core.movement.CheckIfShouldFlip(playerPos(), kingdata.CanFlip);
            kingdata.Kingpos = _King.transform.position;
            kingdata.Playerpos = _Player.transform.position;

            Debug.Log(HealthPercent());
            if(HealthPercent() >= 0.6)
            {
                kingdata.phase2 = false;

                kingdata.phase1 = true;
            }else if(HealthPercent() <= 0.59)
            {
                kingdata.phase1 = false;
                kingdata.phase2 = true;
                Phase2();
            }

        }
        private void FixedUpdate()
        {
            core.LogicUpdate();
            
        }
        private int playerPos()
        {
            if (_King.transform.position.x < _Player.transform.position.x)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        private void Animationfinish(){

            kingdata.AnimationDone = true;
            }
        private float HealthPercent()
        {
            return (enemyData.health / enemyData.maxhealth);
        }
        private void Phase2()
        {
            sprite.color = Color.black;
        }
    }
}
