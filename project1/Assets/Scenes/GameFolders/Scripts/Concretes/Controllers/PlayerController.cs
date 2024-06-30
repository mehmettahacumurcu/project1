using project1.inputs;
using project1.movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] float turnSpeed;
    Mover mover;
    DefaultInput input;
    Rotator rotator;
    bool isForceUp;
    float leftRight;

    private void Awake()
    {
        input = new DefaultInput();
        mover = new Mover(GetComponent<Rigidbody>());
        rotator = new Rotator(GetComponent<PlayerController>());
    }


    void Update()
    {
        if (input.isForceUp)
        {
            isForceUp = true;
        }
        else
        {
            isForceUp = false;
        }

        leftRight = input.LeftRight;
    }

    private void FixedUpdate()
    {
        Debug.Log("Input is force up: " + isForceUp);
        Debug.Log("Left Right Input : " + input.LeftRight);
        if (isForceUp) 
        {
            mover.FixedTick(force);
        }

        rotator.FixedTick(leftRight , turnSpeed);   
    }
}
