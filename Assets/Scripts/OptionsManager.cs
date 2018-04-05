using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour {

    public Slider backgroundSlider;
    public Slider voiceSlider;
    
    void Start () {
        
        backgroundSlider.value = PlayerPrefsManager1.GetMasterBackgroundVolume();
        voiceSlider.value = PlayerPrefsManager1.GetMasterVoiceVolume();
    }

	void Update () {
        
        //Calling our PlayerPrefsManager class and setting the volume
        PlayerPrefsManager1.SetMasterBackgroundVolume(backgroundSlider.value);
        PlayerPrefsManager1.SetMasterVoiceVolume(voiceSlider.value);
    }

    public void ChangeLanguageToFR()
    {
        PlayerPrefsManager1.SetLanguageToFrench();
    }

    public void ChangeLanguageToEN()
    {
        PlayerPrefsManager1.SetLanguageToEnglish();
    }
}
