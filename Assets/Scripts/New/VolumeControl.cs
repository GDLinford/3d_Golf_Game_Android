using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    //All music came from a free asset site called OpenGameArt

    public AudioMixer volume;
    public Slider vSlider;

    void Start()
    {
        vSlider.value = PlayerPrefs.GetFloat("MusicVolume, 0f");
    }
    public void SetLevel(float sliderValue)
    {
        volume.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }

}
