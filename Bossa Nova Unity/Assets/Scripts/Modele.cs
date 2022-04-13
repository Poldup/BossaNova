using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Modele : MonoBehaviour, IPointerDownHandler
{
    public UnityEvent OnPointerDownnnn;
    
    
    
    
    
    public static bool active;

    private LineRenderer ligne;

    private Vector3 mousePos;

    private bool pointEstActif;

    private GameObject[] points;
    private String[] nomPoints;

    public int nbrPoints;
   // public bool point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11;

    // Start is called before the first frame update
    void Start()
    {

        //points[0] = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
        



    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }


/* public void  CreationLigne()

   
    {
        ligne = GetComponentInParent<LineRenderer>();
        ligne.SetPosition(0, new Vector3(this.transform.position.x, this.transform.position.y, 0));
        ligne.SetPosition(1, new Vector3(mousePos.x, mousePos.y, 0));




        if (pointEstActif)
        {
            
            ligne.SetPosition(0, new Vector3(this.transform.position.x, this.transform.position.y, 0));
            ligne.SetPosition(1, new Vector3(points[0].transform.position.x, points[0].transform.position.y, 0));
            
        }
        
        
        
        
        
        
    }
 


    /*public void ConnectionFixe()
    {

        if (nom == nomSuivant + 1)
        {
            Debug.Log("connection fixe"); 
            connectionEnd = this.GetComponentInChildren<LineRenderer>();
            connectionEnd.enabled = true;
            connectionStart.enabled = false;
            connectionEnd.SetPosition(0, new Vector3(this.transform.position.x, this.transform.position.y, 0));
            connectionEnd.SetPosition(1, new Vector3(pointSuivant.transform.position.x, pointSuivant.transform.position.y, 0));
        }
        
 if (EventSystem.current.IsPointerOverGameObject() && this.name == "1")
        {
            point1 = true;
        }


        if (EventSystem.current.IsPointerOverGameObject() && this.name == "2")
        {
            point2 = true;
        }
        
        if (EventSystem.current.IsPointerOverGameObject() && this.name == "3")
        {
            point3 = true;
        }
        if (EventSystem.current.IsPointerOverGameObject() && this.name == "4")
        {
            point4 = true;
        }
        if (EventSystem.current.IsPointerOverGameObject() && this.name == "5")
        {
            point5 = true;
        }
        if (EventSystem.current.IsPointerOverGameObject() && this.name == "6")
        {
            point6 = true;
        }
        if (EventSystem.current.IsPointerOverGameObject() && this.name == "7")
        {
            point7 = true;
        }
        if (EventSystem.current.IsPointerOverGameObject() && this.name == "8")
        {
            point8 = true;
        }
        if (EventSystem.current.IsPointerOverGameObject() && this.name == "9")
        {
            point9 = true;
        }
        if (EventSystem.current.IsPointerOverGameObject() && this.name == "10")
        {
            point10 = true;
        }
        if (EventSystem.current.IsPointerOverGameObject() && this.name == "11")
        {
            point11 = true;
        }


    }*/
    
    }

   


