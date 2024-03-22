using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyAfterLogoPresents : MonoBehaviour
{
    public GameObject screen;
    public RawImage rawImage;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(screen, 10.9f);
        Invoke("FadeOut", 4.9f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FadeOut() {
        rawImage.CrossFadeAlpha(0, 2, false);
        transform.LeanMoveLocalY(5,3);
        LeanTween.scale(screen, new Vector3(20, 20, 20), 3).setEase(LeanTweenType.easeInSine);
    }
}
