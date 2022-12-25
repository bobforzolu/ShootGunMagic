using Laurence.Game_utilities.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class BossControler : MonoBehaviour
    {
        private GameObject _Player;
        private GameObject samuripos;

        public musicmanager music;
        public samuriSo samuri;
        public GameObject unlock;
        public Core core { get; private set; }
        // Start is called before the first frame update
        void Start()
        {
            core = GetComponentInChildren<Core>();
            _Player = GameObject.FindGameObjectWithTag("Player");
            samuripos = this.gameObject;

        }

        // Update is called once per frame
        void Update()
        {
            core.LogicUpdate();
            flipboss();
            samuri.distanceToTarger = Vector2.Distance(samuripos.transform.position, _Player.transform.position);
            samuri.canAttack = CanAttack();
        }
        private int playerPos()
        {
            if (this.transform.position.x < _Player.transform.position.x)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public void flipboss()
        {
            core.movement.CheckIfShouldFlip(playerPos(), samuri.canflip);

        }
        private void OnDisable()
        {
            music.playdefualt();
            unlock.SetActive(false);
        }
        public bool CanAttack()
        {

            return Time.time > samuri.attackTimer + samuri.attackcooldown;
        }
    }
}
