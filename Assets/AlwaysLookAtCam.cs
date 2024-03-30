using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlwaysLookAtCam : MonoBehaviour
{
    private new Transform camera;
    private float updateInterval = 1f; // Set the update interval to 1 second
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= updateInterval)
        {
            ScaleAndLookAt();
            timer = 0f;
        }
    }

    void ScaleAndLookAt()
    {
        if (Time.time % 2 < 0.5)
        {
            transform.LeanScale(new Vector3(1, 1, 1), 1f);
        }
        else
        {
            transform.LeanScale(new Vector3(2, 2, 2), 1f);
        }
        transform.LookAt(camera.position);
    }
}

