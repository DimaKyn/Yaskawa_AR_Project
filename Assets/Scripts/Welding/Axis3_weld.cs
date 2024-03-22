using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using System.Threading;


public class Axis3_weld : MonoBehaviour
{
    public void rotateLeft60Deg() {
        Vector3 rotationDirection = new Vector3(60, 0, 0);
        transform.LeanRotate(rotationDirection, 1f);
        Invoke("return0", 11f);
    }
    
    public void return0() {
        transform.LeanRotate(new Vector3(0, 0, 0), 1f);
    }
}
