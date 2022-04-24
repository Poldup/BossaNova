using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGravity : MonoBehaviour
{
    void Start()
    {
        transform.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
}
