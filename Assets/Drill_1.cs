using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using System.Threading;

public class Drill_1 : MonoBehaviour
{

    public static int drilled = 0;

    public void Axis0_rotate()
    {
        transform.LeanRotate(new Vector3(0, -13, 0), 1);
        Invoke("Axis0_drill_hole_2", 4f);
        Invoke("Axis0_back_to_start", 8f);
    }

    public void Axis0_drill_hole_2() {
        transform.LeanRotate(new Vector3(0, 12, 0), 1.5f);
    }

    public void Axis0_back_to_start() {
        transform.LeanRotate(new Vector3(0, 0, 0), 1);
    }

    /* Axis 1 *///////////////////////////////////////////////////////////



    /////////////////////////////////////////////////////////////////////

    public void Axis2_rotate()
    {
        transform.LeanRotate(new Vector3(0, -13, -87), 1.5f);
        Invoke("Axis2_drill", 2f);
        Invoke("Axis2_drill2", 6f);
        Invoke("Axis2_back_to_start", 8f);
    }

    public void Axis2_drill() {
        transform.LeanRotate(new Vector3(0, -13, -84), 1);
        Invoke("Axis2_return", 1f);
    }

    public void Axis2_drill2()
    {
        transform.LeanRotate(new Vector3(0, 12, -84), 1);
        Invoke("Axis2_return2", 1f);
    }

    public void Axis2_return() {
        transform.LeanRotate(new Vector3(0, -13, -87), 1);
    }

    public void Axis2_return2()
    {
        transform.LeanRotate(new Vector3(0, 12, -87), 1);
    }

    public void Axis2_back_to_start()
    {
        transform.LeanRotate(new Vector3(0, 0, 0), 1.5f);
    }

    /////////////////////////////////////////////////////////////////////


    public void Axis4_rotate()
    {
        transform.LeanRotate(new Vector3(0, -13, -85), 1.5f);
        Invoke("Axis4_back_to_start", 8f);
    }

    public void Axis4_back_to_start()
    {
        transform.LeanRotate(new Vector3(0, 0, 0), 1.5f);
        drilled = 0;
    }




}
        