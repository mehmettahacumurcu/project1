using project1.inputs;
using project1.managers;
using project1.movements;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] float turnSpeed;
    Mover mover;
    DefaultInput input;
    Rotator rotator;
    Fuel fuel;
    bool isForceUp;
    float leftRight;
    bool ableToMove;
    public bool canMove => ableToMove;


    private void Awake()
    {
        input = new DefaultInput();
        mover = new Mover(GetComponent<Rigidbody>());
        rotator = new Rotator(mover.rigidBody.GetComponent<PlayerController>());
        fuel = GetComponent<Fuel>();
        ableToMove = true;
    }


    void Update()
    {
        if (!canMove) return;

        if (input.isForceUp && !fuel.IsEmpty)
        {
            isForceUp = true;
        }
        else
        {
            isForceUp = false;
            fuel.FuelIncrease(0.003f);
        }

        leftRight = input.LeftRight;
    }

    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += HandleOnGameOver;
        GameManager.Instance.OnSuccess += HandleOnSuccess;
    }

    private void HandleOnGameOver()
    {
        ableToMove = false;
        isForceUp = false;
        leftRight = 0f;
        fuel.FuelIncrease(0f);
    }

    private void HandleOnSuccess()
    {
        ableToMove = false;
        isForceUp = false;
        leftRight = 0f;
        fuel.FuelIncrease(0f);
    }

    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= HandleOnGameOver;
        GameManager.Instance.OnSuccess -= HandleOnSuccess;
    }

    private void FixedUpdate()
    {
        Debug.Log("Input is force up: " + isForceUp);
        Debug.Log("Left Right Input : " + input.LeftRight);
        if (isForceUp) 
        {
            mover.FixedTick(force);
            fuel.FuelDecrease(0.2f);
        }

        rotator.FixedTick(leftRight , turnSpeed);   
    }
}
