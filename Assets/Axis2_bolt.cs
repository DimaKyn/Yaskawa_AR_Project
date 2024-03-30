using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis2_bolt : MonoBehaviour
{    public void startBolting1() {
        Invoke("MoveToScrew", 3f);
        Invoke("ScrewBolt1", 4f);
    }

    void MoveToScrew() {
        transform.LeanRotate(new Vector3(0, -2.3f, -60f), 1f);
    }

    void ScrewBolt1() {
        transform.LeanRotate(new Vector3(0, -2.3f, -65f), 1f);
    }

    public void startBolting2() {
        Invoke("LiftToPickBolt", 0f);
        Invoke("MoveToScrew", 3f);
        Invoke("ScrewBolt2", 4f);
    }

    void LiftToPickBolt() {
        transform.LeanRotate(new Vector3(0, -20f, -55f), 1f);
    }

    void ScrewBolt2() {
        transform.LeanRotate(new Vector3(0, -2.3f, -60f), 1f);
    }

    public void startBolting3() {
        Invoke("LiftToPickBolt", 0f);
        Invoke("MoveToScrew", 3f);
        Invoke("ScrewBolt3", 4f);
        Invoke("MoveToStart", 8f);
    }

    void ScrewBolt3() {
        transform.LeanRotate(new Vector3(0, 2.3f, -60f), 1f);
    }

        void MoveToStart() {
        transform.LeanRotate(new Vector3(0, 0, 0), 1f);
    }




}
