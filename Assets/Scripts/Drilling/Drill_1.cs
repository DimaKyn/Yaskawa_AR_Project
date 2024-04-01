using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using System.Threading;
using Unity.VisualScripting;

public class Drill_1 : MonoBehaviour
{

    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;
    public GameObject plateNoHoles;
    public GameObject plateOneHole;
    public GameObject plateTwoHoles;


    public static int drilled = 0;

    public void Axis0_rotate()
    {
        if (source3 != null)
        {
            Debug.Log("source3");
            source3.Play();
        }
        transform.LeanRotate(new Vector3(0, -13, 0), 1);
    }

    public void Axis0_start_drill_hole_2()
    {
        Invoke("Axis0_drill_hole_2", 0f);
        Invoke("Axis0_back_to_start", 2f);
    }

    public void Axis0_drill_hole_2()
    {
        transform.LeanRotate(new Vector3(0, 12, 0), 1.5f);
    }

    public void Axis0_back_to_start()
    {
        transform.LeanRotate(new Vector3(0, 0, 0), 1);
    }

    /* Axis 1 *///////////////////////////////////////////////////////////
    public void Axis1_rotate()
    {
        transform.LeanRotate(new Vector3(0, -13, -55), 1.5f);
        Invoke("Axis1_drill", 2f);
    }
    public void Axis1_drill()
    {
        transform.LeanRotate(new Vector3(0, -13, -60), 1);
        if (source1 != null)
        {
            Invoke("PlaySound1", 0.5f);
        }
        Invoke("Axis1_return", 1f);
        Invoke("setActiveNoHoles", 2f);
    }

    public void setActiveNoHoles()
    {
        if (plateNoHoles != null)
        {
            plateNoHoles.SetActive(false);
        }
    }

    public void Axis1_drill_hole_2()
    {
        Invoke("Axis1_drill2", 0f);
        Invoke("Axis1_back_to_start", 2f);

    }
    public void PlaySound1()
    {
        source1.Play();
    }


    public void Axis1_drill2()
    {
        transform.LeanRotate(new Vector3(0, 12, -60), 1);
        if (source2 != null)
        {
            Invoke("PlaySound2", 0.5f);
        }
        Invoke("Axis1_return2", 1f);
        Invoke("setActiveOneHole", 2f);
    }

    public void setActiveOneHole()
    {
        if (plateOneHole != null)
        {
            plateOneHole.SetActive(false);
        }
    }

    public void PlaySound2()
    {
        source2.Play();
    }


    public void Axis1_return()
    {
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
    }

    public void Axis2_drill()
    {
        transform.LeanRotate(new Vector3(0, -13, -84), 1);
        Invoke("Axis2_return", 1f);
    }

    public void Axis2_drill_hole_2()
    {
        Invoke("Axis2_drill2", 0f);
        Invoke("Axis2_back_to_start", 2f);
    }

    public void Axis2_drill2()
    {
        transform.LeanRotate(new Vector3(0, 12, -84), 1);
        Invoke("Axis2_return2", 1f);
    }

    public void Axis2_return()
    {
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
    }

    public void Axis4_drill_hole_2()
    {
        Invoke("Axis4_back_to_start", 2f);
    }

    public void Axis4_back_to_start()
    {
        transform.LeanRotate(new Vector3(0, 0, 0), 1.5f);
        drilled = 0;
    }

}
