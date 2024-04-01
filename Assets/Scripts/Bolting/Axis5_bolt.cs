using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis5_bolt : MonoBehaviour
{
    public void startBolting1() {
        transform.LeanRotate(new Vector3(0, -20f, 0), 1f);
    }
}
