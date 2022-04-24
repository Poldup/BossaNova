using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class DeplacementSouris : MonoBehaviour
{
    public float mouseSpeed;

    private Vector2 movement;
    private Rigidbody2D rb;

    // Update is called once per frame
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //Debug.Log(Input.GetAxis("Mouse ScrollWheel"));
        //rb.velocity= movement;
        
        transform.Translate(movement);
        transform.GetChild(0).transform.Rotate(0,0, Input.GetAxis("Mouse ScrollWheel")*100, Space.Self);
    }

    private void Update()
    {
        movement= new Vector2(Mathf.Clamp(Input.GetAxis("Mouse X"),-1,1)*mouseSpeed, Mathf.Clamp(Input.GetAxis("Mouse Y"),-1,1)*mouseSpeed);
    }
}
