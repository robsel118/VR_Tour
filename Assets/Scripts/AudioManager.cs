using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
  
    private AudioSource audio;
   
    public void PlayAudio(AudioSource audioToPlay)
    {
        //if no audio, we assign it
        if (audio==null)
        {
            audio = audioToPlay;
        }
       //check if no clip is playing to play the new audio
        if (!audio.isPlaying)
        {
            audio = audioToPlay;
            audio.Play();
        }
    }

    void Update()
    {
        if (audio!=null)
        {
            audio.volume = PlayerPrefsManager1.GetMasterVoiceVolume();
        }
    }
}
