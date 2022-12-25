using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class musicmanager : MonoBehaviour
    {
        public AudioSource musiplayer;
        public musiceventManager EventManager;
        public music[] music;
        public int currentmusic = 0;
        private void Start()
        {
            PlaySound(music[currentmusic].musicclip);
        }
        public void PlaySound(AudioClip sound)
        {
            musiplayer.clip = sound;
            musiplayer.Play();
        }
        public void playsamuri()
        {
            currentmusic = 1;
            PlaySound(music[currentmusic].musicclip);

        }
        public void playdefualt()
        {
            currentmusic = 0;
            PlaySound(music[currentmusic].musicclip);

        }
    }
}
