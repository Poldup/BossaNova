using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class DeplacementSouris : MonoBehaviour
{
    public float mouseSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(Input.GetAxis("Mouse ScrollWheel"));
        transform.Translate(Mathf.Clamp(Input.GetAxis("Mouse X"),-1,1) * mouseSpeed, Mathf.Clamp(Input.GetAxis("Mouse Y"),-1,1) * mouseSpeed, 0);
        transform.Rotate(0,0, Input.GetAxis("Mouse ScrollWheel")*100, Space.Self);
    }
}
