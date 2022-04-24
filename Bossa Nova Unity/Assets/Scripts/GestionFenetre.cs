
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class GestionFenetre : MonoBehaviour, IPointerDownHandler
{
    public WichSchema modele;
    
    public GameObject fenetreObject;
    public Animator fenetreAnim;
    private bool isOpen;
    private float transitionTime = 1.8f;

    public Coroutine lancement;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
        if (fenetreObject.activeInHierarchy)
        {
           // StartCoroutine(Desactivation());

        }

        if (fenetreObject.activeInHierarchy == false)
        {
            fenetreObject.SetActive(true);
            Debug.Log("ouverture");
            fenetreAnim.SetTrigger("Open");
            StartCoroutine(Activation());
            

        }
        
        
    }
    

    IEnumerator Activation()
    {
        
       //fenetre.SetActive(true);
        Debug.Log("ouverture");
        //fenetreAnim.SetTrigger("Open");
        yield return new WaitForSeconds(transitionTime);
       // modele.ActivationRandom();
       modele.LancementJeu();

    }
    
}  
