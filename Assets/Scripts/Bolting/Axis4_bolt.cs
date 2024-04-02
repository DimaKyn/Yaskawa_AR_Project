using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis4_bolt : MonoBehaviour
{
    public void startBolting1() {
        transform.LeanRotate(new Vector3(0, -20f, 0), 1f);
        Invoke("MoveToPickBolt1", 1f);
        Invoke("MoveToScrewBolt1", 3f);
        Invoke("MoveToScrewBolt1", 4f);
    }

    void MoveToPickBolt1() {
        transform.LeanRotate(new Vector3(0, -20f, -90f), 1f);
    }

    void MoveToScrewBolt1() {
        transform.LeanRotate(new Vector3(0, -2.3f, -89f), 1f);
    }

    public void startBolting2()
    {
        Invoke("MoveToPickBolt1", 0f);
        Invoke("MoveToScrewBolt2", 4f);
    }

    void MoveToScrewBolt2()
    {
        transform.LeanRotate(new Vector3(0, -2.3f, -87f), 1f);
    }

    public void startBolting3()
    {
        Invoke("MoveToPickBolt1", 0f);
        Invoke("MoveToScrewBolt3", 4f);
        Invoke("MoveToStart", 8f);
    }

    void MoveToScrewBolt3()
    {
        transform.LeanRotate(new Vector3(0, 2.3f, -87f), 1f);
    }

    void MoveToStart() {
        transform.LeanRotate(new Vector3(0, 0, 0), 1f);
    }



}
