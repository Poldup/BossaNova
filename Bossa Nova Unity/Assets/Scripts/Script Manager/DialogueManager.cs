using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI texteDialogue;
    [SerializeField] private Dialogues dialogueActuel;
    [SerializeField] private ListesDialogues listeDialogues;

    private int index;

    private bool changement;

    public float tempsEcriture = 0.05f;
    

    [SerializeField] private GameObject boiteDialogue;

    [SerializeField] private SystemeJourSuivant jourSuivant;


    private void Start()
    {
        AffichageDialogue();

    }
    
    
    IEnumerator EffetTexte()
    {
        //dialogueActuel = listeDialogues.dialogueSelectionne;
        foreach (char lettre in dialogueActuel.DialoguesObjet[index].ToCharArray())
        {
            texteDialogue.text += lettre;
            yield return new WaitForSeconds(tempsEcriture);
        }

        changement = true;
        StartCoroutine(ChangementTexte());
    }

    IEnumerator ChangementTexte()
    {
        if ( index < dialogueActuel.DialoguesObjet.Length - 1)
        {
            index++;
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
            changement = false;
            Debug.Log(index);
            texteDialogue.text = "";
            dialogueActuel.dialogueFini = true;
            StartCoroutine(EffetTexte());

        }

        else
        {
           yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
            texteDialogue.text = "";
            dialogueActuel = null;
            boiteDialogue.SetActive(false);
            index = 0;
            Destroy(dialogueActuel);

        }

    }
    

    public void AffichageDialogue()
    {
        listeDialogues.ChoixDialogue();
        dialogueActuel = listeDialogues.dialogueSelectionne;
        Debug.Log(listeDialogues.dialogueSelectionne);
        boiteDialogue.SetActive(true);
        StartCoroutine(EffetTexte());
        Debug.Log(index);

    }

}



    
        
    
    
    


