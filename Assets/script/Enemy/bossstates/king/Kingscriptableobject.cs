using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;
namespace Laurence
{
    [CreateAssetMenu(fileName = "boss Energy",menuName = "Boss Data / Energy")]
    public class Kingscriptableobject : ScriptableObject
    {
        [Header("king data")]
        public int Energy;
        public int MaxEnergy;

        [Header("animation data")]

        public float walkDuration;
        public float relaxtime;
        public int range;
        public bool AnimationDone;
        public float distanceToTarger;
        public bool CanFlip;

        [Header("movement and location data")]

        public float speed;
        public Vector2 Kingpos;
        public Vector2 Playerpos;


        public float hit1movespeed;
        public float hit2movespeed;

        [Header("teloprt points data")]
        public int restpoint;
        public Vector2[] restlocation;


        [Header("phase data")]
        public bool phase1;
        public bool phase2;

       
        
        public event Action OnTeleport;
        public void Teleporttrigger()
        {
            OnTeleport?.Invoke();
        }


    }
}