using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAfter8Sec : MonoBehaviour
{
    public GameObject disappearObject;
    public void DisappearAfter8Sec()
    {
        Invoke("DisappearNow", 8f);
    }
    public void DisappearNow()
    {
        disappearObject.SetActive(false);
    }
}
