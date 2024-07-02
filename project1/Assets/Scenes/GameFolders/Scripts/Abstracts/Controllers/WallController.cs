using project1.managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace project1.abstracts.controllers
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();

            if (playerController != null) 
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

