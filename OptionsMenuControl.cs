using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenuControl : MonoBehaviour
{
    public AudioMixer HomeScreenMusic;

    public void setVolume(float volume)
    {
        HomeScreenMusic.SetFloat("HomeAudioVolExposedParam",volume);
    }

    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
