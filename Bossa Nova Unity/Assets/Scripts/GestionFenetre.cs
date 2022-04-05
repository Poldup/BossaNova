using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class GestionFenetre : MonoBehaviour, IPointerDownHandler
{
    public GameObject fenetre;
    public Animator fenetreAnim;
    private bool isOpen;
    private float transitionTime = 1.8f;
    
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
        
        if (fenetre.activeInHierarchy)
        {
            StartCoroutine(Desactivation());
        }

        if (fenetre.activeInHierarchy == false)
        {
            fenetre.SetActive(true);
            Debug.Log("ouverture");
            fenetreAnim.SetTrigger("Open");

           // StartCoroutine(Activation());

        }
        
        
    }

    IEnumerator Desactivation()
            {
                Debug.Log("fermeture");
                fenetreAnim.SetTrigger("Close");
                yield return new WaitForSeconds(transitionTime);
                fenetre.SetActive(false);
            }

   /* IEnumerator Activation()
    {
        fenetre.SetActive(true);
        Debug.Log("ouverture");
        fenetreAnim.SetTrigger("Open");

    }
    */
}  
