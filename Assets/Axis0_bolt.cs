using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis0_bolt : MonoBehaviour
{
    public GameObject bolt;
    public void startBolting1() {
        transform.LeanRotate(new Vector3(0, -20f, 0), 1f);
        Invoke("ActivateBolt", 3f);
        //Invoke("ScrewBolt1", 4f);
    }
    
    // Activate bolt, now the robot has it in its head, ready to bolt
    void ActivateBolt() {
        bolt.SetActive(true);
    }

    void ScrewBolt1() {
        Debug.Log("Screwing bolt");
        transform.LeanRotate(new Vector3(0, 2.6f, 0), 1f);
    }



}
