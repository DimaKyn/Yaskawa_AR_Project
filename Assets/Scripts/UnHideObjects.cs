using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnHideObjects : MonoBehaviour
{
    public GameObject Object1, Object2, Object3, Object4;

    public void UnHideObject1(){
        if(Object1 != null){
            bool isActive = Object1.activeSelf;
            Object1.SetActive(true);
        }
    }

    public void UnHideObject2(){
        if(Object2 != null){
            bool isActive = Object2.activeSelf;

            Object2.SetActive(!isActive);
        }
    }
    public void UnHideObject3(){
        if(Object3 != null){
            bool isActive = Object3.activeSelf;

            Object3.SetActive(!isActive);
        }
    }
    public void unHideAll(){
        UnHideObject1();
        UnHideObject2();
        UnHideObject3();
    }

    public void specialUnhide(){
        if(Object4 != null){
            bool isActive = Object4.activeSelf;
            if(!isActive){
                Object4.SetActive(true);
            }
        }
    }
}
