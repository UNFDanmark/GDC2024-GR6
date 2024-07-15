using System;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraMovement : MonoBehaviour 
{

    //Assingables
    public Transform playerCam;
    public Transform orientation;

    //Rotation and look     
    private float xRotation;
    public float sensitivity = 100f;
    public float normalPosition;
    public float crouchPosition;
    private float desiredX;

    private void Start()
    {
        normalPosition = transform.localPosition.y-0.1f;
        crouchPosition = transform.localPosition.y - 0.5f;
    }

    private void Update()
    { 
        normalPosition = transform.localPosition.y-0.1f;
        crouchPosition = transform.localPosition.y - 0.5f;
        
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.fixedDeltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.fixedDeltaTime;

        //Find current look rotation
        Vector3 rot = playerCam.transform.localRotation.eulerAngles;
        desiredX = rot.y + mouseX;
        
        //Rotate, and also make sure we dont over- or under-rotate.
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Perform the rotations
        playerCam.transform.localRotation = Quaternion.Euler(xRotation, desiredX, 0);
        orientation.transform.localRotation = Quaternion.Euler(0, desiredX, 0);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerCam.position = new Vector3(playerCam.position.x,crouchPosition, playerCam.position.z);
            print("camera position " + playerCam.position.y);
        }else
        {
            playerCam.transform.position = new Vector3(transform.position.x, normalPosition, transform.position.z);
        }
    }
}
