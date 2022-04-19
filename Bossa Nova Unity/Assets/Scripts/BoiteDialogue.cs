using System;
using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class BoiteDialogue : MonoBehaviour
{
    [SerializeField] private TMP_Text texte;

    [SerializeField] private GameObject dialogueBoite;

    [SerializeField] public DialoguesSysteme listeDialogues;

    [SerializeField] private List<DialoguesSysteme> dialogueCopie = new List<DialoguesSysteme>();
    [SerializeField] private DialoguesSysteme[] dialogueChoisis = new DialoguesSysteme[6];

    [SerializeField] private DialoguesSysteme test;
    [SerializeField] private DialoguesSysteme dialogueJeu;
    
    private EffetTexte effetEcriture;
    // Start is called before the first frame update
    private void Start()
    {
        effetEcriture = GetComponent<EffetTexte>();
        FermetureBoiteDialogue();
        ApparitionDialogue(test);
        //texte.text = "Bien Le bonjour ! \nComment vous allez ?";
    }

    // Update is called once per frame

    public void ApparitionDialogue(DialoguesSysteme texteDialogue)
    {
        dialogueBoite.SetActive(true);
        StartCoroutine(ChangementDialogue(texteDialogue));
    }

    private IEnumerator ChangementDialogue(DialoguesSysteme texteDialogue)
    {
        foreach (string dialogue in texteDialogue.Dialogue)
        {
            yield return effetEcriture.Effet(dialogue, texte);
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        }

        FermetureBoiteDialogue();
    }

    private void FermetureBoiteDialogue()
    {
        dialogueBoite.SetActive(false);
        texte.text = String.Empty;
    }
  
}
