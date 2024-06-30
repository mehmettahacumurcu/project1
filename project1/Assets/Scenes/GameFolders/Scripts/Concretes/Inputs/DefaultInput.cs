using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project1.inputs
{
    public class DefaultInput
    {
        DefaultAction input;
        public bool isForceUp { get; private set; }
        public float LeftRight { get; private set; }
        public DefaultInput()
        {
            input = new DefaultAction();

            input.Rocket.ForceUp.performed += context => isForceUp = context.ReadValueAsButton();
            input.Rocket.LeftRight.performed += context => LeftRight = context.ReadValue<float>();

            input.Enable();
        }

        
    }
}

