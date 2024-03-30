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
        Debug.Log("Click");
    }

    
}
