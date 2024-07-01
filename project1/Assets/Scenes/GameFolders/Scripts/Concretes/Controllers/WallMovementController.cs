using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using project1.abstracts.controllers;


namespace project1.controllers
{
    public class WallMovementController : WallController
    {
        [SerializeField] Vector3 direction;
        [SerializeField] float factor;
        [SerializeField] float speed = 1f;
        Vector3 startingPosition;
        private const float FULL_CIRCLE = Mathf.PI * 2f;

        private void Awake()
        {
            startingPosition = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / speed;
            factor = Mathf.Abs(Mathf.Sin(cycle * FULL_CIRCLE));

            Vector3 offset = direction * factor;
            transform.position = startingPosition + offset;
        }
    }
}

