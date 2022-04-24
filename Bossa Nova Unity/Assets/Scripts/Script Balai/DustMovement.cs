using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustMovement : MonoBehaviour
{
    private Vector2 movement;
    // Update is called once per frame
    void FixedUpdate()
    {
        movement = DeplacementSouris.instance.movement;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="balai")
        {
            transform.Translate(movement);
        }
    }
}
