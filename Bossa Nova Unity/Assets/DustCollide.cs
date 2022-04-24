using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustCollide : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="poussiere")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
