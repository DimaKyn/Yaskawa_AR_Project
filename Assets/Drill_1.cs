using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using System.Threading;

public class Drill_1 : MonoBehaviour
{

    public AudioSource source1;
    public AudioSource source2;

    public GameObject drillHead;


    public static int drilled = 0;

    public void Axis0_rotate()
    {
        if (drillHead != null) {
            drillHead.SetActive(true);
        }
        transform.LeanRotate(new Vector3(0, -13, 0), 1);
        Invoke("Axis0_drill_hole_2", 4f);
        Invoke("Axis0_back_to_start", 8f);
        Invoke("RemoveHead", 9.5f);
    }

    public void Axis0_drill_hole_2() {
        transform.LeanRotate(new Vector3(0, 12, 0), 1.5f);
    }

    public void Axis0_back_to_start() {
        transform.LeanRotate(new Vector3(0, 0, 0), 1);
    }

    /* Axis 1 *///////////////////////////////////////////////////////////
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
        if (source1 != null) {
            Invoke("PlaySound1", 0.5f);
        }
        Invoke("Axis1_return", 1f);
        
    }
    public void PlaySound1() {
        source1.Play();
    }


    

    public void Axis1_drill2()
    {
        transform.LeanRotate(new Vector3(0, 12, -60), 1);
        if (source2 != null) {
            Invoke("PlaySound2", 0.5f);
        }
        
        Invoke("Axis1_return2", 1f);
    }

    public void PlaySound2() {
        source2.Play();
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

    public void RemoveHead() {
        if (drillHead != null) {
            drillHead.SetActive(false);

        }
    }

}
        