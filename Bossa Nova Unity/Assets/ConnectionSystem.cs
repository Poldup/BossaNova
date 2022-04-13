using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConnectionSystem : MonoBehaviour, IPointerDownHandler
{
    private GameObject pointStockage;
    public GameObject[] points;
    private int nbrPoints;
    public LineRenderer ligne;

    public Modele script ;

    // Start is called before the first frame update
    void Start()
    {
        nbrPoints = points.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void OnPointerDown(PointerEventData eventData)
    {
       // Debug.Log("bouton activé");
        if (eventData.pointerCurrentRaycast.gameObject.name == "1")
        {

            Debug.Log(this.name);

        }

        if (eventData.pointerClick.gameObject.name == "1")
        {
            Debug.Log(this.name);
            
        }
    }
}
