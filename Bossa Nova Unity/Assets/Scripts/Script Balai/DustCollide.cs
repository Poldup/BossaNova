using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "poussiere2")
        {
            collision.gameObject.SetActive(false);
            Debug.Log("ça marche");
        }
    }
}
