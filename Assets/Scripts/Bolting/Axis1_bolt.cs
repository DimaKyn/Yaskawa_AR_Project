using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis1_bolt : MonoBehaviour
{
    // Axis 1 moves downward to pick up the bolt
    public void startBolting1() {
        transform.LeanRotate(new Vector3(0, -20f, 0), 1f);
        Invoke("MoveToPickBolt1", 1f);
        Invoke("PickUpBolt", 2f);
        Invoke("MoveToScrewBolt1", 3f);
    }

    void MoveToPickBolt1() {
        transform.LeanRotate(new Vector3(0, -20f, -58), 1f);
    }

    void PickUpBolt() {
        transform.LeanRotate(new Vector3(0, -20f, -52), 1f);
    }

    void MoveToScrewBolt1() {
        transform.LeanRotate(new Vector3(0, -2.3f, -52), 1f);
    }

    public void startBolting2() {
        Invoke("MoveToPickBolt2", 0f);
        Invoke("PickUpBolt", 1f);
        Invoke("MoveToPickBolt2", 2f);
        Invoke("MoveToScrewBolt2", 3f);
    }

    void MoveToPickBolt2() {
        transform.LeanRotate(new Vector3(0, -20f, -52), 1f);
    }

    void MoveToScrewBolt2() {
        transform.LeanRotate(new Vector3(0, -2.3f, -55), 1f);
    }

    public void startBolting3() {
        Invoke("MoveToPickBolt2", 0f);
        Invoke("PickUpBolt", 1f);
        Invoke("MoveToPickBolt2", 2f);
        Invoke("MoveToScrewBolt3", 3f);
        Invoke("MoveToStart", 8f);
    }

    void MoveToScrewBolt3() {
        transform.LeanRotate(new Vector3(0, 2.3f, -55), 1f);
    }

    void MoveToStart() {
        transform.LeanRotate(new Vector3(0, 0, 0), 1f);
    }





}
