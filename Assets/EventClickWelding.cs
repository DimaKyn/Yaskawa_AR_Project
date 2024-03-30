using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class EventClickWelding : MonoBehaviour, IPointerClickHandler
{

    public GameObject[] yaskawaRobot;
    public GameObject torus;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked");
    }

    private void OnMouseUpAsButton() {
        torus.SetActive(false);
        yaskawaRobot[0].GetComponent<Axis0>().startWelding();
        yaskawaRobot[1].GetComponent<Axis1_weld>().startWelding();
        yaskawaRobot[2].GetComponent<Axis2_weld>().startWelding();
        yaskawaRobot[3].GetComponent<Axis3_weld>().rotateLeft60Deg();
    }

    
}
