using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using UnityEngine.UI;

public class DeplacementSouris : MonoBehaviour
{
    public float mouseSpeed;
    public float rotateSpeed;
    //public ScrollRect scroll;
    //public float mouseWheelSensitivity;

    private Vector2 movement;
    private float wheel;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        
        //Debug.Log(Input.GetAxis("Mouse ScrollWheel"));
        //rb.velocity= movement;
        //wheel = Input.mouseScrollDelta.y * rotateSpeed;
        movement = new Vector2(Mathf.Clamp(Input.GetAxis("Mouse X"), -1, 1) * mouseSpeed, Mathf.Clamp(Input.GetAxis("Mouse Y"), -1, 1) * mouseSpeed);
        //wheel = Input.GetAxis("Mouse ScrollWheel") * rotateSpeed;
        transform.Translate(movement);
        //transform.GetChild(0).transform.Rotate(0,0, wheel, Space.Self);
    }

    private void Update()

    {
        wheel = rotateSpeed;
        if (Input.GetAxisRaw("Mouse ScrollWheel") > 0)
        {
            transform.GetChild(0).transform.Rotate(0, 0, wheel, Space.Self);
        }
        else if (Input.GetAxisRaw("Mouse ScrollWheel") < 0)
        {
            transform.GetChild(0).transform.Rotate(0, 0, -wheel, Space.Self);
        }

        //movement= new Vector2(Mathf.Clamp(Input.GetAxis("Mouse X"),-1,1)*mouseSpeed, Mathf.Clamp(Input.GetAxis("Mouse Y"),-1,1)*mouseSpeed);
        //wheel = Input.GetAxis("Mouse ScrollWheel") * rotateSpeed;

    }
}
