using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListesDialogues : MonoBehaviour
{
    [SerializeField] public List<Dialogues> toutLesDialogues = new List<Dialogues>();
    [SerializeField] public List<Dialogues> copieToutLesDialogues = new List<Dialogues>();

    [SerializeField] public Dialogues dialogueSelectionne;

    [SerializeField] private SystemeJourSuivant joursuivant;
    
    


    // Start is called before the first frame update
    void Start()
    {
        ChoixDialogue();
    }

    // Update is called once per frame
   
    public void ChoixDialogue()
    {
        Dialogues dialogueStock;
        copieToutLesDialogues = new List<Dialogues>(toutLesDialogues);
        dialogueStock = toutLesDialogues[joursuivant.quelJour];
        dialogueSelectionne = dialogueStock;
    }
   
    
}
