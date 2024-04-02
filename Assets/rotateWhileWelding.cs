using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateWhileWelding : MonoBehaviour
{
    public bool isWelding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isWelding)
        {
            transform.Rotate(Vector3.back, 60f * Time.deltaTime);
        }
    }
}
