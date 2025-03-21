using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    // Ik heb alles gelabeld zodat het makelijk is om te identificeren. - J.J.

    float Sensitivity = 5f;
    private Rigidbody rb;

    public Camera MainCamera;  //Camera 1
    public Camera ThirdPerson; // Third Person Camera
    void Start()
    {

        MainCamera.gameObject.SetActive(true);
        ThirdPerson.gameObject.SetActive(false);
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X");

        transform.Rotate(0, mouseX * Sensitivity, 0);

        if (Input.GetKeyUp(KeyCode.V))
        {
            SwitchCameras();
        }

        void SwitchCameras()
        {
            if (MainCamera.gameObject.activeSelf)
            {

                MainCamera.gameObject.SetActive(false);
                ThirdPerson.gameObject.SetActive(true);
            }
            else
            {
                MainCamera.gameObject.SetActive(true);
                ThirdPerson.gameObject.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                UnlockCursor();
            }

            if (Input.GetMouseButton(0))
            {
                LockCursor();
            }

            void LockCursor()
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }

            void UnlockCursor()
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }



    }
}
