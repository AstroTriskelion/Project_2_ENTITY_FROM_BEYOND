using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class _Background_Sounds : MonoBehaviour
{
	[Header("AUDIO MIXER WITH DIFFERENT BACKGROUND OST \n")]
	public AudioMixerSnapshot Music1;
    public AudioMixerSnapshot Music2;
    public AudioMixerSnapshot Music3;
	public AudioMixerSnapshot Music4;
	private float NumberMusic;
	[Header("ENTITY CONNECTION \n")]
	public GameObject ENTITY;
	public GameObject SFX_HELP;

	void Start()
    {
        NumberMusic = 0;
    }
    public void ChangeMusic()
    {
        if (NumberMusic == 0)
        {
            Music1.TransitionTo(3);
            NumberMusic = 1;
        }

        else if (NumberMusic == 1)
        {
            Music2.TransitionTo(3);
            NumberMusic = 2;
        }

        else if (NumberMusic == 2)
        {
            Music3.TransitionTo(3);
            NumberMusic = 0;
			ENTITY.GetComponent<_ENTITY>().hint();
			SFX_HELP.SetActive(true);
		}
		else
		return;
			
		
	}

	public void CutMusic()
		{
			Music4.TransitionTo(0);
			NumberMusic = 4;
		}

	
}

