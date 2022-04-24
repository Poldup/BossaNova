using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public AudioMixer audioMixer;

    public TransitionLevel changementLevel;

    public GameObject titreMenu;
    public Button jouer;
    public Button option;
    public Button quitter;

    private Animator animationMenu;
    private Animator animationJouer;
    private Animator animationOption;
    private Animator animationQuitter;

    public SystemeJourSuivant systemeJour;

    private float transitionTime  = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
       ApparitionMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitterJeu()
    {
        Application.Quit();
        
    }

    public void Volume(float volumeMusique)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(volumeMusique) * 20);
    }


    public void SceneJeu()
    {
        changementLevel.SceneJeu();
    }


    private void ApparitionMenu()
    {
        animationMenu = titreMenu.GetComponent<Animator>();
        animationJouer = jouer.GetComponent<Animator>();
        animationOption = option.GetComponent<Animator>();
        animationQuitter = quitter.GetComponent<Animator>();

        StartCoroutine(MenuPrincipal());
    }

    IEnumerator MenuPrincipal()
    {
        
        yield return new WaitForSeconds(transitionTime);
        animationMenu.SetTrigger("AnimationStart");
    }


    public void JourSuivant()
    {
        
        StartCoroutine(ChangementJour());
        
    }

    IEnumerator ChangementJour()
    {
        yield return new WaitForSeconds(transitionTime);
        animationMenu.SetTrigger("AnimationStart");
    }
    
}
