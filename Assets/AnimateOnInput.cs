using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;  // XRI RightHand Interaction/Activate Value (Input Action Reference) 
    public InputActionProperty gripAnimationAction;   // XRI RightHand Interaction/Select Value (Input Action Reference)
    public Animator handAnimator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", triggerValue);
    }
}
