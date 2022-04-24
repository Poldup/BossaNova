using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class GestionFenetrePold : MonoBehaviour, IPointerDownHandler
{
    
    public GameObject fenetreObject;
    public GameObject miniJeu;
    public Animator fenetreAnim;
    private float transitionTime = 1.8f;


    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("clic");
        if (fenetreObject.activeInHierarchy == false)
        {
            fenetreObject.SetActive(true);
            fenetreAnim.SetTrigger("Open");
            StartCoroutine(Activation());
        }
    }


    IEnumerator Activation()
    {
        yield return new WaitForSeconds(transitionTime);
        miniJeu.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
