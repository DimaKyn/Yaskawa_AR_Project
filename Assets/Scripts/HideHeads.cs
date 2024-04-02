using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHeads : MonoBehaviour
{
    public GameObject DrillHead;
    public GameObject WeldingHead;
    public GameObject BoltHead;
    public int step;

    public void HideHeadsOnButtonPress() {
        if (step == 0) {
            DrillHead.SetActive(true);
            WeldingHead.SetActive(false);
            BoltHead.SetActive(false);
        } else if (step == 1){
            DrillHead.SetActive(false);
            WeldingHead.SetActive(true);
            BoltHead.SetActive(false);
        } else if (step == 2){
            DrillHead.SetActive(false);
            WeldingHead.SetActive(false);
            BoltHead.SetActive(true);
        }


    }
}
