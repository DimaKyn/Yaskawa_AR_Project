using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis3_arm : MonoBehaviour
{
    public float maxDegreesUp = 90;
    public float maxDegreesDown = 90;
    public float tiltSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 rotationDirection = new Vector3(1, 0, 0);



        transform.Rotate(rotationDirection * tiltSpeed * Time.deltaTime, Space.Self);

    }
}
