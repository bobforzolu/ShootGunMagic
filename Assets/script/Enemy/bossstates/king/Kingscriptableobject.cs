using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Laurence
{
    [CreateAssetMenu(fileName = "boss Energy",menuName = "Boss Data / Energy")]
    public class Kingscriptableobject : ScriptableObject
    {
        [Header("king data")]
        public int Energy;
        public int MaxEnergy;

        public float walkDuration;
        public float relaxtime;
        public int range;
        public bool AnimationDone;

        public float distanceToTarger;

        public bool CanFlip;
        public float speed;
        public Vector2 Traget1;
        public Vector2 Traget2;


        public float hit1movespeed;
        public float hit2movespeed;


        public int restpoint;
        public Transform[] restlocation;

    }
}
