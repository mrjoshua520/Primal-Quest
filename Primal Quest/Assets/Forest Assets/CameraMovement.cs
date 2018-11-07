using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speedLeftRight = 2f;
    public float speedUpDown = 2f;
    private float leftRight = 0f;
    private float upDown = 0f;
    GameObject character;
    // Use this for initialization
    void Start()
    {
        //Because this script is not attached to our player we have to find
        //that object by using the code below.
        character = GameObject.Find("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //This will make sure that the cursor cannot leave the screen
        //if you want the cursor to leave the screen press escape
        //Given by Joshua
        Cursor.lockState = CursorLockMode.Locked;
        leftRight += speedLeftRight * Input.GetAxis("Mouse X");
        upDown += speedUpDown * Input.GetAxis("Mouse Y");

        //This will move the camera
        transform.eulerAngles = new Vector3(upDown * -1, leftRight, 0f);
        //This will roate the player so that the player and the camera are
        //facing the right direction.
        character.transform.eulerAngles = new Vector3(0f, leftRight, 0f);
    }
}
