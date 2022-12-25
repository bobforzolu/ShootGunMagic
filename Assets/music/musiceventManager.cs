using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Laurence
{
    [CreateAssetMenu(fileName = "Audio Player", menuName ="audio / audio Manager")]
    public class musiceventManager : ScriptableObject
    {
        public event Action<AudioClip> OnMusicPlay;
        public void Play(AudioClip sound)
        {
            OnMusicPlay?.Invoke(sound);
        }
    }
}
