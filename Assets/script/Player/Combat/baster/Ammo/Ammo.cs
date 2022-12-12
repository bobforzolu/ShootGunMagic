using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public  class Ammo : MonoBehaviour
    {
        public AmmoType ammoType;
        public float lifeTime;
        public float Onhitime = 0f;
        private IDamagable DAMAGBLEENEMIES;
        public PlayerData playerData;
        private int facingdir;
        private Vector2 movement;

        private void Start()
        {
            facingdir = playerData.FacingDirection;
            movement = new Vector2(ammoType.speed * Time.deltaTime * facingdir,0);
            if(facingdir == -1)
            {
                transform.localScale = new Vector3(transform.localScale.x * facingdir,1,1);
            }
        }
        private void Update()
        {
            transform.Translate( movement);
            Destroy(lifeTime);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Ammotyp");
            if (collision.CompareTag("Enemy"))
            {
                Instantiate(ammoType.AmmoHitEffect, collision.transform.position, Quaternion.identity);
            }
            if(Onhitime <= 0)
            {
                Destroy(this.gameObject);
            }
            
        }
        public void Destroy(float time)
        {
            Destroy(this.gameObject, time);
        }



    }
}
