using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public Transform Target;

    private void Update()
    {
        transform.LookAt(Target);
    }

}
