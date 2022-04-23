using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuManager : MonoBehaviour
{

    public AudioMixer audioMixer;

    public TransitionLevel changementLevel;

    public GameObject startMenu;

    private Animator animationMenu;

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
        animationMenu = startMenu.GetComponent<Animator>();
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
