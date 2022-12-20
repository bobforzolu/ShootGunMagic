using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class KingController : MonoBehaviour
    {
        public Kingscriptableobject kingdata;
        private GameObject _Player;
        private GameObject _King;


        public Core core { get; private set; }

        private void Start()
        {
            _Player = GameObject.FindGameObjectWithTag("Player");
            _King = GameObject.FindGameObjectWithTag("King");
            core = GetComponentInChildren<Core>();

        }
        public void Update()
        {
            kingdata.distanceToTarger = Vector2.Distance(_King.transform.position, _Player.transform.position);
            core.movement.CheckIfShouldFlip(playerPos(), kingdata.CanFlip);
            kingdata.Traget1 = _King.transform.position;
            kingdata.Traget2 = _Player.transform.position;

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
    }
}
