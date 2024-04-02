using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreKeyPress : MonoBehaviour
{
    private GameObject MainEntity;
    void Start()
    {
        MainEntity = GameObject.FindGameObjectWithTag("ENTITY");
        Debug.Log("ENTITY CONNECTED");
    }

    public void SaveInput()
	{
        string CurrentTag = gameObject.tag;
        Debug.Log(CurrentTag);
        MainEntity.GetComponent<_ENTITY>().AddToString(CurrentTag);
	}

    public void CallReset()
    {
        MainEntity.GetComponent<_ENTITY>().HARDRESET();
    }
}
