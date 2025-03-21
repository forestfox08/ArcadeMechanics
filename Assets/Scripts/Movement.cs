using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float moveSpeed = 5;
    float sensitivity = 5;
    public GameObject Camera;
    public GameObject cameraFocus;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * moveSpeed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * moveSpeed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * moveSpeed * Time.deltaTime;

        }

        //float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetAxis("Mouse Y");

        //transform.Rotate(0, mouseX * sensitivity, 0);
        //cameraFocus.transform.Rotate(-mouseY * sensitivity, 0, 0);

    }
}
