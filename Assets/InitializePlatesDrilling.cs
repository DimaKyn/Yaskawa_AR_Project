using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlatesDrilling : MonoBehaviour
{
    public GameObject metalPlate_two_holes;
    public GameObject metalPlate_one_hole;
    public GameObject metalPlate_no_holes;

    public Drill_1_Axis1 drill_1_axis1;
    public GameObject yaskawa;

    public void Awake() {
    }

    public void Start()
    {
        var rotation = Quaternion.Euler(-90, 0, 0);
        Instantiate(metalPlate_two_holes, new Vector3(0.775f, 0, 0), rotation);
        Instantiate(metalPlate_one_hole, new Vector3(0.775f, 0, 0), rotation);
        Instantiate(metalPlate_no_holes, new Vector3(0.775f, 0, 0), rotation);
    }

    public void Update() {
        drill_1_axis1 = yaskawa.GetComponent<Drill_1_Axis1>();

        if (drill_1_axis1.drilled == 1) {
            Destroy(metalPlate_no_holes);
        }
        else if (drill_1_axis1.drilled == 2) {
            Destroy(metalPlate_one_hole);
        }
    }

}
