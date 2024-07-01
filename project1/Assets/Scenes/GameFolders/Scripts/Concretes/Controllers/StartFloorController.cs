using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace project1.controllers
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision collision)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();

            if (playerController != null) 
            {
                Destroy(this.gameObject);
            }
        }
    }
}

