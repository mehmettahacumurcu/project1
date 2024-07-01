using project1.managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace project1.controllers
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController playerController = collision.collider.GetComponent<PlayerController>();

            if (playerController != null && playerController.canMove) 
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

