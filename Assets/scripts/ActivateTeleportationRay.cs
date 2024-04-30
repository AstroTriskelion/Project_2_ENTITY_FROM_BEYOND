using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;

    public InputActionProperty leftActivate;
    public XRRayInteractor leftRay;

    public InputActionProperty leftCancel;

    /*
    public float starttime = 0f;
    public float timer = 0f;
    private float holdTime = 2f;
    public GameObject reticle;
    public bool held = false;
    */
    void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid);
        leftTeleportation.SetActive(leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1f);


		//Debug.Log("Trigger is currently " + leftTrigger.action.ReadValue<float>());
		/*if(leftActivate.action.ReadValue<float>() >= 1f)
        {
            starttime += Time.deltaTime;
            timer = starttime;
            if(timer >  holdTime)
			{
                held = true;
                leftTeleportation.SetActive(true);
                reticle.SetActive(true);

            }
        }
        if (leftActivate.action.ReadValue<float>() <1f)
        {
            held = false;
            starttime = 0f;
            timer = 0f;
            leftTeleportation.SetActive(false);
            reticle.SetActive(false);
        }*/

		//!isLeftRayHovering

	}

}
