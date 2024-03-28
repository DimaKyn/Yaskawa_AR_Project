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
        Invoke("LowerToBoltIn", 4f);

    }

    void MoveToPickBolt1() {
        transform.LeanRotate(new Vector3(0, -20f, -55), 1f);
    }

    void PickUpBolt() {
        transform.LeanRotate(new Vector3(0, -20f, -58), 1f);
    }

    void MoveToScrewBolt1() {
        transform.LeanRotate(new Vector3(0, 2.6f, -52), 1f);
    }

    void LowerToBoltIn() {
        transform.LeanRotate(new Vector3(0, 2.6f, -55), 1.5f);
    }


}
