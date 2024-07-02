using project1.abstracts.utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace project1.managers
{
    public class SoundManager : SingletonHandler<SoundManager>
    {
        
        AudioSource[] audioSource;

        
        private void Awake()
        {
            SingletonPatternHandler(this);

            audioSource = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
            if(!audioSource[index].isPlaying)
            {
                audioSource[index].Play();
            }
            
        }

        public void StopSound(int index)
        {
            if (audioSource[index].isPlaying)
            {
                audioSource[index].Stop();
            }
        }

        
    }
}

