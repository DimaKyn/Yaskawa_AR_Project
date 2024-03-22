using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis1_weld : MonoBehaviour
{
    public void startWelding() {
        Invoke("positionForWelding", 1f);
        Invoke("weldLeanForward", 3f);
        Invoke("positionForWelding", 5f);
        Invoke("weldLeanForward", 7f);
        Invoke("return0", 9);
    }

    public void positionForWelding() {
        transform.LeanRotate(new Vector3(0, -3, 285), 2f);
    }

    public void weldLeanForward() {
        transform.LeanRotate(new Vector3(0, -3, 282), 2f);
    }
    public void return0() {
        transform.LeanRotate(new Vector3(0, 0, 0), 2f);
    }


}
