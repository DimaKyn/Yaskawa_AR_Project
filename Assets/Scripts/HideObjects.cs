using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObjects : MonoBehaviour
{
    public GameObject Canva1, Canva2, PlaneFinder;
    [SerializeField] private bool True;

    public void HideCanva1(){
        if(Canva1 != null){
            //bool isActive = Canva1.activeSelf;
            Canva1.SetActive(false);
        }
    }

    public void HideCanva2(){
        if(Canva2 != null){
            bool isActive = Canva2.activeSelf;

            Canva2.SetActive(!isActive);
        }
    }
    public void HidePlaneFinder(){
        if(PlaneFinder != null){
            bool isActive = PlaneFinder.activeSelf;

            PlaneFinder.SetActive(!isActive);
        }
    }
}
