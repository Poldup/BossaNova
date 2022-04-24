using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class DeplacementSouris : MonoBehaviour
{
    public float mouseSpeed;
    public float rotateSpeed;

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
        
        transform.Translate(movement);
        transform.GetChild(0).transform.Rotate(0,0, wheel, Space.Self);
    }

    private void Update()
    {
        movement= new Vector2(Mathf.Clamp(Input.GetAxis("Mouse X"),-1,1)*mouseSpeed, Mathf.Clamp(Input.GetAxis("Mouse Y"),-1,1)*mouseSpeed);
        wheel = Input.GetAxis("Mouse ScrollWheel") * rotateSpeed;
    }
}
