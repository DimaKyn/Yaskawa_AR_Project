using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill_1_Axis1 : MonoBehaviour
{
    public int drilled = 0;
    
    public void Axis1_rotate()
    {
        transform.LeanRotate(new Vector3(0, -13, -55), 1.5f);
        Invoke("Axis1_drill", 2f);
        Invoke("Axis1_drill2", 6f);
        Invoke("Axis1_back_to_start", 8f);
    }
    public void Axis1_drill()
    {
        transform.LeanRotate(new Vector3(0, -13, -60), 1);
        Invoke("Axis1_return", 1f);
    }

    public void Axis1_drill2()
    {
        transform.LeanRotate(new Vector3(0, 12, -60), 1);
        Invoke("Axis1_return2", 1f);
    }

    public void Axis1_return() {
        transform.LeanRotate(new Vector3(0, -13, -55), 1);
        drilled = 1;
    }

    public void Axis1_return2()
    {
        transform.LeanRotate(new Vector3(0, 12, -55), 1);
        drilled = 2;
    }

    public void Axis1_back_to_start()
    {
        transform.LeanRotate(new Vector3(0, 0, 0), 1.5f);
    }
}
