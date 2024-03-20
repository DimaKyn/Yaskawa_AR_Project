using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource soundEffectsSrc;
    public AudioClip sfxButtonClick, sfxInfoPop;

    public void Button(){
        soundEffectsSrc.clip = sfxButtonClick;
        soundEffectsSrc.Play();
    }

    public void InfoPopUp(){
        soundEffectsSrc.clip = sfxInfoPop;
        soundEffectsSrc.Play();
    }
}
