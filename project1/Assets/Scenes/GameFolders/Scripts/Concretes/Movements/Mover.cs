using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project1.movements
{
    public class Mover
    {
        Rigidbody rigidBody;

        public Mover(Rigidbody rigidbody)
        {
            rigidBody = rigidbody;
        }

        public void FixedTick(float force)
        {
            rigidBody.AddRelativeForce(Vector3.up * force * Time.deltaTime);
        }
    }

}
