using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class _Background_Sounds : MonoBehaviour
{
    public AudioMixerSnapshot Music1;
    public AudioMixerSnapshot Music2;
    public AudioMixerSnapshot Music3;
    public float NumberMusic;

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
        }
    }
}
