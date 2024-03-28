using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis2_bolt : MonoBehaviour
{    public void startBolting1() {
        Invoke("MoveToScrew", 3f);
        Invoke("ScrewBolt1", 4f);
    }

    void MoveToScrew() {
        transform.LeanRotate(new Vector3(0, -2.3f, -66f), 1f);
    }

    void ScrewBolt1() {
        transform.LeanRotate(new Vector3(0, -2.3f, -66f), 1f);
    }
}
