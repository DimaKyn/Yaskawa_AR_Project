using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis1_weld : MonoBehaviour
{
    // Starts the welding process by invoking the necessary functions at specific time intervals.
    public void startWelding() {
        Invoke("positionForWelding", 1f);
        Invoke("weldLeanForward", 3f);
        Invoke("positionForWelding", 5f);
        Invoke("weldLeanForward", 7f);
        Invoke("return0", 9);
    }

    // Positions the object for welding by rotating it to a specific angle.
    public void positionForWelding() {
        transform.LeanRotate(new Vector3(0, -3, 285), 2f);
    }

    /// Performs a forward lean for welding by rotating the object to a specific angle.
    public void weldLeanForward() {
        transform.LeanRotate(new Vector3(0, -3, 282), 2f);
    }

    /// Returns the object to its initial position by rotating it to the default angle.
    public void return0() {
        transform.LeanRotate(new Vector3(0, 0, 0), 2f);
    }
}
