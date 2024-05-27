using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Record_Audio : MonoBehaviour
{
    public int sampleWindow = 64;
    private AudioClip microphoneClip;
    string microphoneName = null;

	private void Start()
	{
		microphoneName = Microphone.devices[0];
        int i = 0;
        foreach (string device in Microphone.devices)
        {
            Debug.Log(i + device);
            i++;
        }
	}

	public void MicrophoneToAudioClip()
    { 
        microphoneClip = Microphone.Start(microphoneName, false, 2, AudioSettings.outputSampleRate);
        AudioClipToFile();

	}

	public float GetLoudnessFromMicrophone()
    {
        return GetLoudnessFromAudioClip(Microphone.GetPosition(Microphone.devices[0]), microphoneClip);
    }

	public void AudioClipToFile()
	{
		Microphone.End(microphoneName);
        SavWav.Save("Recordings", microphoneClip);
	}

	public float GetLoudnessFromAudioClip(int clipPosition, AudioClip clip)
    {
        int startPosition = clipPosition - sampleWindow;

        if (startPosition < 0)
        {
            return 0;
        }
        float[] waveData = new float[sampleWindow];
        clip.GetData(waveData, startPosition);

        //compute loudness
        float totalLoudness = 0;
        for(int i = 0; i < sampleWindow; i++)
        {
            totalLoudness += Mathf.Abs(waveData[i]);
        }

        return totalLoudness / sampleWindow;

    }
}
