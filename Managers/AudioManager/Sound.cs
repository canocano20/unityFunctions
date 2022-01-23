﻿using UnityEngine.Audio;
using UnityEngine;

namespace CanCandir.Audio
{
    [System.Serializable]
    public class Sound
    {
        public AudioClip clip;

        public string name;

        public bool loop;

        [Range(0f, 1f)]
        public float volume;
        [Range(.1f, 3f)]
        public float pitch;

        [HideInInspector]
        public AudioSource source;
    }
}