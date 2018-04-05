using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multi_Language_Audio : MonoBehaviour {

    public AudioClip french;
    public AudioClip english;
   
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (PlayerPrefsManager1.GetSelectedLanguage()=="EN")
        {
            source.clip = english;
        }
        else
        {
            source.clip = french;
        }
    }
}
