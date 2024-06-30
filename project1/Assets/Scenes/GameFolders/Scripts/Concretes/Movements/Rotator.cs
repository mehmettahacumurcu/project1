using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project1.movements
{
    public class Rotator
    {
        Rigidbody rigidBody;
        PlayerController playerController;

        public Rotator(PlayerController playerController)
        {
            this.playerController = playerController;
            rigidBody = playerController.GetComponent<Rigidbody>();
        }
        
        public void FixedTick(float direction , float turnSpeed)
        {

            
            if (direction == 0)
            {
                rigidBody.freezeRotation = true;
            }
            else
            {
                playerController.transform.Rotate(Vector3.back * direction * turnSpeed * Time.deltaTime);
            }
            

        }
    }
}

