using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveOSC : MonoBehaviour
{
    public OSC osc;
    private string emotion;
    private GameObject ALIEN;

	void Start()
    {
        osc.SetAddressHandler("/mlp", OnReceiveXYZ);

        Debug.Log("GOT UNITY MESSAGE");
        ALIEN = GameObject.FindWithTag("ENTITY");
        

    }

    void OnReceiveXYZ(OscMessage message)
    {
        Debug.Log("message = " + message);
        emotion = ("");
        emotion = emotion + message; 
        if (emotion.Contains("neutral"))
        {
            Debug.Log("ENTITY IS NEUTRAL");
            ALIEN.GetComponent<_ENTITY>().OTHER_REACT("NEUTRAL");

		}
        else if(emotion.Contains("happy")) 
        {
            Debug.Log("ENTITY IS HAPPY");
			ALIEN.GetComponent<_ENTITY>().POSITIVE_REACT("DOMISOL");
		}
        else if(emotion.Contains("sad"))
        {
            Debug.Log("ENTITY IS SAD");
			ALIEN.GetComponent<_ENTITY>().OTHER_REACT("SAD");
		}
        else{
            Debug.Log("FAILURE");
        }
    }

    
}
