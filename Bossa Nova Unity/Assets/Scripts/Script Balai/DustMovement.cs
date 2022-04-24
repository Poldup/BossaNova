using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustMovement : MonoBehaviour
{
    public Vector2 movement;
    public Vector2 surroundDustMovement;
    public Vector2 actualMovement;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (movement!=null)
        {
            actualMovement = movement;
        }
        else if (surroundDustMovement!=null)
        {
            actualMovement = surroundDustMovement;
        }
        else
        {
            actualMovement = new Vector2(0, 0);
        }
        transform.Translate(actualMovement);
        movement = actualMovement = new Vector2(0,0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="poussiere2")
        {
            if (movement != null)
            {
                collision.gameObject.GetComponent<DustMovement>().surroundDustMovement=movement;
            }
            else if (surroundDustMovement != null)
            {
                collision.gameObject.GetComponent<DustMovement>().surroundDustMovement=surroundDustMovement;
            }
            
        }
    }
}
