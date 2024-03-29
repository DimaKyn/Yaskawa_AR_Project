using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltingHead_bolt : MonoBehaviour
{
    public GameObject bolt1;
    public GameObject bolt2;
    public GameObject bolt3;
    public GameObject boltOnHead;
    public void startBolting1() {
        Invoke("Bolt1", 5f);
        Invoke("ActivateBolt1", 6f);
        Invoke("LiftAfterBolt1", 6f);
        Invoke("ActivateTorus2", 7f);
    }

    void Bolt1() {
        transform.LeanMove(transform.position + new Vector3(0, -0.05f, 0), 1f);
    }

    void ActivateBolt1() {
        bolt1.SetActive(true);
        boltOnHead.SetActive(false);
    }

    void LiftAfterBolt1() {
        transform.LeanMove(transform.position + new Vector3(0, 0.05f, 0), 1f);
    }

    public void startBolting2() {
        Invoke("PickUpBolt2", 1f);
        Invoke("LiftAfterPickupBolt2", 2f);
        Invoke("Bolt2", 5f);
        Invoke("ActivateBolt2", 6f);
        Invoke("LiftAfterBolt2", 6f);
    }

    void PickUpBolt2() {
        transform.LeanMove(transform.position + new Vector3(0, -0.05f, 0), 1f);
    }

    void LiftAfterPickupBolt2() {
        transform.LeanMove(transform.position + new Vector3(0, 0.05f, 0), 1f);
    }

    void Bolt2() {
        transform.LeanMove(transform.position + new Vector3(0, -0.05f, 0), 1f);
    }

    void ActivateBolt2() {
        bolt2.SetActive(true);
        boltOnHead.SetActive(false);
    }

    void LiftAfterBolt2() {
        transform.LeanMove(transform.position + new Vector3(0, 0.05f, 0), 1f);
    }

    public void startBolting3() {
        Invoke("PickUpBolt2", 1f);
        Invoke("LiftAfterPickupBolt2", 2f);
        Invoke("Bolt2", 5f);
        Invoke("ActivateBolt3", 6f);
        Invoke("LiftAfterBolt2", 6f);
    }

    void ActivateBolt3() {
        bolt3.SetActive(true);
        boltOnHead.SetActive(false);
    }
}
