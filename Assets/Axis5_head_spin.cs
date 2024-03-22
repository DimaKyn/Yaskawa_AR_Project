using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis5_head_spin : MonoBehaviour
{
    [SerializeField]
    public float rotateSpeed = 1800;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 rotationDirection = new Vector3(0, 0, 1);

        transform.Rotate(rotationDirection * rotateSpeed * Time.deltaTime, Space.Self);
    }
}
