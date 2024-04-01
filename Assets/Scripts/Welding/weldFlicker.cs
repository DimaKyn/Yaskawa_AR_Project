using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class weldFlicker : MonoBehaviour
{
    public Light lightOB;

    public float flickerSpeed = 0.05f;
    public float minTime;
    public float maxTime;

    public float timer;

    void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        lightFlicker();
    }

    // Function to control light flickering
    public void lightFlicker() {
        if (timer > 0) {
            timer -= Time.deltaTime;
        }

        if (timer <= 0) {
            lightOB.enabled = !lightOB.enabled;        
            timer = Random.Range(minTime, maxTime);
        }
    }

}
