using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class Paralex : MonoBehaviour
    { // The speed at which the backgrounds move
        private Transform camaera;
        private Vector3 previousecamerapos;
        public Vector2 parallexEffectMultiplier;
        public float textureUnitSizeX;
        private void Start()
        {
            camaera = Camera.main.transform;
            previousecamerapos = camaera.position;
            Sprite sprite = GetComponent<SpriteRenderer>().sprite;
            Texture2D texture = sprite.texture;
            textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
        }
        private void LateUpdate()
        {
            Vector3 deltaMovement = camaera.transform.position - previousecamerapos;
            transform.position += new Vector3( deltaMovement.x * parallexEffectMultiplier.x, deltaMovement.y * parallexEffectMultiplier.y);
            previousecamerapos = camaera.position;


           if(Mathf.Abs( camaera.position.x - transform.position.x) >= textureUnitSizeX)
            {
                float offsetPositionX = (camaera.position.x - transform.position.x) % textureUnitSizeX;
                transform.position = new Vector2(camaera.position.x + offsetPositionX, transform.position.y);
            }
        }

    }
}


