using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis0 : MonoBehaviour
{
    public GameObject pointLight;
    public GameObject areaLight;

    public AudioSource source;
    public AudioClip clip;

    // Rotate the object to the left by 2.3 degrees
    public void rotateLeft_2_3_deg()
    {
        transform.LeanRotate(new Vector3(0, -6f, 0), 1f);
    }

    // Rotate the object to the center position
    public void rotateToCenter()
    {
        transform.LeanRotate(new Vector3(0, 1, 0), 1f);
    }

    // Rotate the object to the right by 2.3 degrees
    public void rotateRight_2_3_deg()
    {
        transform.LeanRotate(new Vector3(0, -2.3f, 0), 1f);
    }

    // Start the welding process
    public void startWelding()
    {
        Invoke("rotateToCenter", 1f);
        Invoke("ActivateLight", 3f);
        Invoke("rotateLeft_2_3_deg", 3f);
        Invoke("rotateToCenter", 4f);
        Invoke("rotateLeft_2_3_deg", 5f);
        Invoke("rotateToCenter", 6f);
        Invoke("rotateRight_2_3_deg", 7f);
        Invoke("rotateToCenter", 8f);
        Invoke("rotateRight_2_3_deg", 9f);
        
        Invoke("DeactivateLight", 9f);
        Invoke("rotateToCenter", 10f);
        Invoke("return0", 11f);
    }

    // Activate the point light and area light
    public void ActivateLight()
    {
        pointLight.SetActive(true);
        areaLight.SetActive(true);
        if (source != null)
        {
            source.PlayOneShot(clip);
        }
    }

    // Deactivate the point light and area light
    public void DeactivateLight()
    {
        pointLight.SetActive(false);
        areaLight.SetActive(false);
    }

    // Rotate the object back to the initial position
    public void return0()
    {
        transform.LeanRotate(new Vector3(0, 0, 0), 2f);
    }

}
