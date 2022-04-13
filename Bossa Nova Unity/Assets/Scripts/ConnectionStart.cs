using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConnectionStart : MonoBehaviour
{
    public GameObject boutonDepart, BoutonArrive;
    private LineRenderer ligne;
    private Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        



    }



    public void ConnectionSouris()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        ligne = GetComponentInParent<LineRenderer>();
        ligne.SetPosition(0, new Vector3(this.transform.position.x, this.transform.position.y, 0));
        ligne.SetPosition(1, new Vector3(mousePos.x, mousePos.y, 0));
        
        
        
    }
   
}
