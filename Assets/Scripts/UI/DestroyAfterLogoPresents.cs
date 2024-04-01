using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyAfterLogoPresents : MonoBehaviour
{
    public GameObject screen;
    public RawImage rawImage;
    public GameObject audioControlLogo;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(screen, 7.5f);
        Invoke("SetAudioControlLogoActive", 7f);
        Invoke("FadeOut", 5.9f);
    }

    void SetAudioControlLogoActive()
    {
        if (audioControlLogo != null) 
            audioControlLogo.SetActive(true);
    }

    void FadeOut() {
        rawImage.CrossFadeAlpha(0, 2, false);
        LeanTween.moveY(screen, 3850, 2f).setEase(LeanTweenType.easeOutExpo);
        LeanTween.scale(screen, new Vector3(80, 80, 80), 3f).setEase(LeanTweenType.easeInSine);
    }
}
