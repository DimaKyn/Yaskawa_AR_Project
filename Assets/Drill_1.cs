using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using System.Threading;

public class Drill_1 : MonoBehaviour
{
    public void Axis0_rotate()
    {
        transform.LeanRotate(new Vector3(0, -14, 0), 1);
    }

    public void Axis1_rotate()
    {
        transform.LeanRotate(new Vector3(0, -14, -55), 2);
    }

    public void Axis2_rotate()
    {
        transform.LeanRotate(new Vector3(0, -14, -87), 2);
    }


}
        