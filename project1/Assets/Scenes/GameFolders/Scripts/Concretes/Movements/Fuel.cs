using project1.managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project1.movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float maxFuel = 100f;
        [SerializeField] float currentFuel;
        [SerializeField] ParticleSystem particle;
        public float CurrentFuel => currentFuel / maxFuel;
        public bool IsEmpty => currentFuel < 1f;

        private void Awake()
        {
            currentFuel = maxFuel;
        }

        public void FuelIncrease(float increase)
        {
            currentFuel += increase;
            currentFuel = Mathf.Min(currentFuel, maxFuel);

            if(particle.isPlaying)
            {
                particle.Stop();
            }

            SoundManager.Instance.StopSound(0);
        }

        public void FuelDecrease(float decrease)
        {
            currentFuel -= decrease;
            currentFuel = Mathf.Max(currentFuel, 0f);
            if (particle.isStopped)
            {
                particle.Play();
            }

            SoundManager.Instance.PlaySound(0);

        }
    }
}

