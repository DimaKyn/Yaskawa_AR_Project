using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventClickDrilling : MonoBehaviour
{
    public GameObject[] yaskawaRobot;
    public GameObject torus, torus2;

    public GameObject Object, noRewardCanvas, drillingScene;
    public GameObject plateNoHoles, plateOneHole, PlateTwoHoles;
    public int count = 0;

    public int step = 0;

    private void OnMouseUpAsButton()
    {

        if (step == 0)
        {
            Invoke("ActivateTorus2", 3);
            yaskawaRobot[0].GetComponent<Drill_1>().Axis0_rotate();
            yaskawaRobot[1].GetComponent<Drill_1>().Axis1_rotate();
            yaskawaRobot[2].GetComponent<Drill_1>().Axis2_rotate();
            yaskawaRobot[3].GetComponent<Drill_1>().Axis4_rotate();
        }
        else if (step == 1)
        {
            torus.SetActive(false);
            DeactivateTorus2();
            //Axis0 > Axis1 > Axis2 > Axis4 > Bolting head
            yaskawaRobot[0].GetComponent<Drill_1>().Axis0_start_drill_hole_2();
            yaskawaRobot[1].GetComponent<Drill_1>().Axis1_drill_hole_2();
            yaskawaRobot[2].GetComponent<Drill_1>().Axis2_drill_hole_2();
            yaskawaRobot[3].GetComponent<Drill_1>().Axis4_drill_hole_2();

            Invoke("unhideReward", 3);

        }
    }

    public void ActivateTorus2()
    {
        torus.SetActive(false);
        torus2.SetActive(true);
    }

    public void DeactivateTorus2()
    {
        torus2.SetActive(false);
    }

    public void unhideReward()
    {
        if (noRewardCanvas != null && count > 0)
        {
            bool isActiveNoRewards = noRewardCanvas.activeSelf;
            noRewardCanvas.SetActive(!isActiveNoRewards);
        }

        if (Object != null && count == 0)
        {
            count++;
            bool isActive = Object.activeSelf;
            Object.SetActive(!isActive);
        }

        hideDrilling();
    }

    public void hideDrilling()
    {
        if (drillingScene != null)
        {
            drillingScene.SetActive(false);
        }
        torus.SetActive(true);
        plateNoHoles.SetActive(true);
        plateOneHole.SetActive(true);
        PlateTwoHoles.SetActive(true);
    }
}
