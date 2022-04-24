using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustCollideManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag!="Untagged")
        {
            Debug.Log(collision.gameObject.tag);
        }
        if (collision.gameObject.tag=="pelle")
        {
            gameObject.SetActive(false);
            Debug.Log("banger");
            Debug.Log("pelle");
        }
    }
}
