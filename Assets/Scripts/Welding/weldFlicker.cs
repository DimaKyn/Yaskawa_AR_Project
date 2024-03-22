using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class weldFlicker : MonoBehaviour
{
    public Light lightOB;

    public AudioSource lightSound;

    public float flickerSpeed = 0.05f;
    public float minTime;
    public float maxTime;

    public float timer;
    // public Axis0_weld axis0_weld;

    // public void Awake()
    // {
    //     axis0_weld = GetComponent<Axis0_weld>();
    //     isWelding = axis0_weld.isWelding;
    // }


    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        lightFlicker();
    }

    public void lightFlicker() {
        if (timer > 0) {
            timer -= Time.deltaTime;
        }

        if (timer <= 0) {
            lightOB.enabled = !lightOB.enabled;
            lightSound.Play();
            timer = Random.Range(minTime, maxTime);
        }
    }

}
