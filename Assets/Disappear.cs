using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
   public GameObject disappearObject;
    public void DisappearAfter4Sec()
    {
       Invoke("DisappearNow", 4f);
    }
    public void DisappearNow()
    {
        disappearObject.SetActive(false);
    }

   
}
