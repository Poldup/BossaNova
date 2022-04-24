using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public AudioMixer audioMixer
    public TransitionLevel changementLevel;

    public SystemeJourSuivant systemeJour;
    private float transitionTime = 1f;

    [SerializeField] private Animator transitionAnimator;

    [SerializeField] private DialogueManager gestionDialogue;

    [SerializeField] public bool jeuRevisionFini, jeuBalaisFini;

    [SerializeField] private Button jourSuivant;
    

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

    public void Update()
    {
        if (jeuBalaisFini && jeuRevisionFini)
        {
            jourSuivant.gameObject.SetActive(true);
            gestionDialogue.AffichageDialogue();
        }

        if (jeuBalaisFini && jeuRevisionFini && systemeJour.quelJour == 3)
        {
            Debug.Log("Derneir Ecran");
            EcranFinal();
        }

    }

    public void EcranFinal()
    {
        StartCoroutine(ChargementSceneFinal());
        

    }
    
    IEnumerator ChargementSceneFinal()
    {
        
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("SceneFinal");
    }
}


