using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis4_bolt : MonoBehaviour
{
    public void startBolting1() {
        transform.LeanRotate(new Vector3(0, -20f, 0), 1f);
        Invoke("MoveToPickBolt1", 1f);
        Invoke("MoveToPickBolt1", 2f);
        //Invoke("MoveToScrewBolt1", 3f);
        Invoke("ScrewBolt1", 4f);
    }

    void MoveToPickBolt1() {
        transform.LeanRotate(new Vector3(0, -20f, -90f), 1f);
    }

    void MoveToScrewBolt1() {
        transform.LeanRotate(new Vector3(0, -2.3f, -90f), 1f);
    }

    void ScrewBolt1() {
        transform.LeanRotate(new Vector3(0, -2.3f, -88f), 1f);
    }


}
