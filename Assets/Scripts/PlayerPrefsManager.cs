using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager1 : MonoBehaviour {

    const string MASTER_BACKGROUND_VOLUME = "background_volume";
    const string MASTER_VOICE_VOLUME = "voice_volume";
    const string MASTER_LANGUAGE = "language";
    
    public static void SetMasterBackgroundVolume(float volume)
    {
        if (volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_BACKGROUND_VOLUME, volume);
        }
        else
        {
            Debug.LogError("Background Volume out of range");
        }
    }

    public static void SetMasterVoiceVolume(float volume)
    {
        if (volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOICE_VOLUME, volume);
        }
        else
        {
            Debug.LogError("Voice Volume out of range");
        }
    }
    public static float GetMasterBackgroundVolume()
    {
        if (!PlayerPrefs.HasKey(MASTER_BACKGROUND_VOLUME))
        {
            SetMasterBackgroundVolume(0.5f);
        }
        return PlayerPrefs.GetFloat(MASTER_BACKGROUND_VOLUME);
    }

    public static float GetMasterVoiceVolume()
    {
        if (!PlayerPrefs.HasKey(MASTER_VOICE_VOLUME))
        {
            SetMasterVoiceVolume(0.5f);
        }
        return PlayerPrefs.GetFloat(MASTER_VOICE_VOLUME);
    }

    public static void SetLanguageToFrench()
    {
        PlayerPrefs.SetString(MASTER_LANGUAGE, "FR");
    }
    public static void SetLanguageToEnglish()
    {
        PlayerPrefs.SetString(MASTER_LANGUAGE, "EN");
    }

    public static string GetSelectedLanguage()
    {
        if (!PlayerPrefs.HasKey(MASTER_LANGUAGE))
        {
            SetLanguageToEnglish();
        }

        return PlayerPrefs.GetString(MASTER_LANGUAGE);
    }
}
