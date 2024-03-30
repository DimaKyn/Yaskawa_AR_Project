using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis0_bolt : MonoBehaviour
{
    public GameObject bolt;
    public void startBolting1() {
        transform.LeanRotate(new Vector3(0, -20f, 0), 1f);
        Invoke("ActivateBolt", 2f);
        Invoke("ScrewBolt1", 3f);
    }
    
    // Activate bolt, now the robot has it in its head, ready to bolt
    void ActivateBolt() {
        bolt.SetActive(true);
    }

    void ScrewBolt1() {
        transform.LeanRotate(new Vector3(0, -2.3f, 0), 1f);
    }

    public void startBolting2() {
        Invoke("PickUpBolt", 0f);
        Invoke("ActivateBolt", 2f); // Activate bolt, now the robot has it in its head, ready to bolt
        Invoke("ScrewBolt2", 3f);
    }

    void PickUpBolt() {
        transform.LeanRotate(new Vector3(0, -20f, 0), 1f);
    }

    void ScrewBolt2() {
        transform.LeanRotate(new Vector3(0, -2.3f, 0), 1f);
    }

    public void startBolting3() {
        Invoke("PickUpBolt", 0f);
        Invoke("ActivateBolt", 2f); // Activate bolt, now the robot has it in its head, ready to bolt
        Invoke("ScrewBolt3", 3f);
        Invoke("MoveToStart", 8f);
    }

    void ScrewBolt3() {
        transform.LeanRotate(new Vector3(0, 2.3f, 0), 1f);
    }

    void MoveToStart() {
        transform.LeanRotate(new Vector3(0, 0, 0), 1f);
    }



}
