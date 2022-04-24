using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public AudioMixer audioMixer
    public TransitionLevel changementLevel;

    public SystemeJourSuivant systemeJour;
    private float transitionTime = 1f;

    [SerializeField] private Animator transitionAnimator;

    [SerializeField] private DialogueManager gestionDialogue;

    private void Start()
    {
        StartCoroutine(LancementJeu());
    }


    public void JourSuivant()
    {

        StartCoroutine(ChangementJour());

    }

    IEnumerator ChangementJour()
    {
        yield return new WaitForSeconds(3f);

    }



    IEnumerator LancementJeu()
    {
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        Debug.Log("transition");
        transitionAnimator.SetTrigger("LancementAnim");
        yield return new WaitForSeconds(3f);
        gestionDialogue.AffichageDialogue();


    }
}


