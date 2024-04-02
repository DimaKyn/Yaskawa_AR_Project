using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundSettings : MonoBehaviour
{
    [SerializeField] Slider soundSlider;
    [SerializeField] AudioMixer musicMixer;
    // Start is called before the first frame update
    void Start()
    {
        SetVolume(PlayerPrefs.GetFloat("MusicVolume", 0.75f));
    }

    public void SetVolume(float _value)
    {
        if (_value < 1)
        {
            _value = 0.001f;
        }

        RefreshSlider(_value);
        PlayerPrefs.SetFloat("MusicVolume", _value);
        musicMixer.SetFloat("MusicVolume", Mathf.Log10(_value / 100) * 20f);
    }

    public void RefreshSlider(float _value)
    {
        soundSlider.value = _value;
    }

    public void SetVolumeFromSlider()
    {
        SetVolume(soundSlider.value);
    }
}
