using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class EventClick : MonoBehaviour, IPointerClickHandler
{
    public GameObject[] yaskawaRobot;
    public GameObject torus, torus2, torus3;
    public int step = 0; 
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
    }

    private void OnMouseUpAsButton() {
        if (step == 0) {
            return;
        }
        else if (step == 1) {
            torus.SetActive(false);
            Invoke("ActivateTorus2", 7);
            //Axis0 > Axis1 > Axis2 > Axis4 > Bolting head
            yaskawaRobot[0].GetComponent<Axis0_bolt>().startBolting1();
            yaskawaRobot[1].GetComponent<Axis1_bolt>().startBolting1();
            yaskawaRobot[2].GetComponent<Axis2_bolt>().startBolting1();
            yaskawaRobot[3].GetComponent<Axis4_bolt>().startBolting1();
            yaskawaRobot[4].GetComponent<BoltingHead_bolt>().startBolting1();
        }
        else if (step == 2) {
            torus2.SetActive(false);
            Invoke("ActivateTorus3", 7);
            //Axis0 > Axis1 > Axis2 > Axis4 > Bolting head
            yaskawaRobot[0].GetComponent<Axis0_bolt>().startBolting2();
            yaskawaRobot[1].GetComponent<Axis1_bolt>().startBolting2();
            yaskawaRobot[2].GetComponent<Axis2_bolt>().startBolting2();
            yaskawaRobot[3].GetComponent<Axis4_bolt>().startBolting2();
            yaskawaRobot[4].GetComponent<BoltingHead_bolt>().startBolting2();
        }
        else if (step == 3) {
            torus3.SetActive(false);
            //Axis0 > Axis1 > Axis2 > Axis4 > Bolting head
            yaskawaRobot[0].GetComponent<Axis0_bolt>().startBolting3();
            yaskawaRobot[1].GetComponent<Axis1_bolt>().startBolting3();
            yaskawaRobot[2].GetComponent<Axis2_bolt>().startBolting3();
            yaskawaRobot[3].GetComponent<Axis4_bolt>().startBolting3();
            yaskawaRobot[4].GetComponent<BoltingHead_bolt>().startBolting3();


            

        }

    }

    private void ActivateTorus2() {
        torus2.SetActive(true);
    }

    private void ActivateTorus3() {
        torus3.SetActive(true);
    }
    
}
