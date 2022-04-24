using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ListesDialogues : MonoBehaviour
{
    [SerializeField] public List<Dialogues> toutLesDialogues = new List<Dialogues>();
    [SerializeField] public List<Dialogues> copieToutLesDialogues = new List<Dialogues>();

    [SerializeField] public List<GameObject> listesJour = new List<GameObject>();
    [SerializeField] public List<GameObject> copieListesJour = new List<GameObject>();

    [SerializeField] public Dialogues dialogueSelectionne;

    [SerializeField] private GameObject leJour;

    [SerializeField] private SystemeJourSuivant joursuivant;

    [SerializeField] public int numeroDialogue = 0;
    private string nom;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //JeSaisPlusCommentAppeler();
    }

    // Update is called once per frame
   
    public void ChoixDialogue()
    {
        numeroDialogue++;
        Dialogues dialogueStock;
        copieToutLesDialogues = new List<Dialogues>();
        dialogueStock = toutLesDialogues[numeroDialogue];
        dialogueSelectionne = dialogueStock;
    }

    public void PremierDialogue()
    {
        Dialogues dialogueStock;
        copieToutLesDialogues = new List<Dialogues>(toutLesDialogues);
        dialogueStock = toutLesDialogues[numeroDialogue];
        dialogueSelectionne = dialogueStock;
        
    }

    
    public void JeSaisPlusCommentAppeler()
    {
        GameObject jourStock;
        copieListesJour = new List<GameObject>(listesJour);
        jourStock = copieListesJour[joursuivant.quelJour];
        leJour = jourStock;

        List<Dialogues> transfert = new List<Dialogues>();
        transfert = leJour.GetComponent<DialoguesDuJou>().listeDialogue;
        //Merci Encore Anthony "Le Sang" Guerin
        toutLesDialogues = transfert;
        //numeroDialogue++;
        Dialogues dialogueStock;
        copieToutLesDialogues = new List<Dialogues>(toutLesDialogues);
        dialogueStock = toutLesDialogues[numeroDialogue];
        dialogueSelectionne = dialogueStock;
    }

    
}
