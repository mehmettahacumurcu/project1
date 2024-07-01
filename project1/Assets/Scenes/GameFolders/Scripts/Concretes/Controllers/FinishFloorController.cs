using project1.managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace project1.controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject particles;

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();

            if (playerController == null) return;
            

            if(collision.GetContact(0).normal.y == -1)
            {
                particles.gameObject.SetActive(true);
                GameManager.Instance.Success();
            }
            else
            {
                // gameover
                GameManager.Instance.GameOver();
            }
        }

    }
}

