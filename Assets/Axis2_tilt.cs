using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axis2_tilt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localEulerAngles = new Vector3(0f, 0f, 359f);

    }

    // Speed at which the robot head tilts
    public float tiltSpeed = 10f;

    // Target tilt angle
    public float targetTiltAngle = 90f;

    // Whether the robot head is currently tilted up or down
    private bool isTiltedUp = true;

    private float degToRotate = 359;

    private float newTiltAngle = 359;




    void Update()
    {

        // Check if the robot head is tilted up or down
        Debug.Log("transform.localEulerAngles.z: " + transform.localEulerAngles.z);
        Debug.Log("targetTiltAngle: " + targetTiltAngle);

        if (degToRotate <= 360 && degToRotate >= 300 && !isTiltedUp)
        {
            degToRotate = degToRotate - tiltSpeed * Time.deltaTime;
            newTiltAngle = newTiltAngle - tiltSpeed * Time.deltaTime;
        }
        else if (degToRotate >= 300 && degToRotate <= 355 && isTiltedUp)
        {
            degToRotate = degToRotate + tiltSpeed * Time.deltaTime;
            newTiltAngle = newTiltAngle + tiltSpeed * Time.deltaTime;
        }
        else if (degToRotate > 355 && isTiltedUp)
        {
            isTiltedUp = false;
            degToRotate = 355;
            newTiltAngle = 355;
        }
        else if (degToRotate < 300 && !isTiltedUp)
        {
            isTiltedUp = true;
            degToRotate = 300;
            newTiltAngle = 300;
        }

        // Apply the new tilt angle
        transform.localEulerAngles = new Vector3(0f, 0f, newTiltAngle);
    }


    float normalizeAngle(float angle)
    {
        if (angle > 180)
        {
            return angle - 360;
        }
        return angle;
    }


}
