using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoAudioPlayer : MonoBehaviour {

    AudioSource audio;

	void Start () {
        audio = GetComponent<AudioSource>();
	}

     void Update()
    {
        audio.volume = PlayerPrefsManager1.GetMasterBackgroundVolume();
    }
}
