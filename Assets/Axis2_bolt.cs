using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis2_bolt : MonoBehaviour
{    public void startBolting1() {
        Invoke("MoveToScrew", 4f);
        //Invoke("ScrewBolt1", 4f);
    }

    void MoveToScrew() {
        transform.LeanRotate(new Vector3(0, 2.6f, -10f), 1f);
    }
}
