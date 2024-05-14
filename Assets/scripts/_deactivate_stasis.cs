using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _deactivate_stasis : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		//rb.isKinematic = true;
		//rb.useGravity = false;

	}
    public void stasis()
    {
        rb.isKinematic = false;
        //rb.detectCollisions = true;
        rb.useGravity = true;
    }
}
