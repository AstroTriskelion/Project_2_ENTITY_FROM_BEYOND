using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Menu_Tutorial : MonoBehaviour
{
	public Transform head;
	public float spawnDistance = 2;
	public GameObject menu;


	void Start()
	{
		menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
	}
	void Update()
    {
		
		menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
		menu.transform.forward *= -1;
	}
}
