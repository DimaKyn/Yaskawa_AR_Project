using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlwaysLookAtCam : MonoBehaviour
{
    private new Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time % 2 < 1) {
            transform.LeanScale(new Vector3(1, 1, 1), 1f);
        } else {
            transform.LeanScale(new Vector3(2, 2, 2), 1f);
        }
        transform.LookAt(camera.position);
        

    }
}

