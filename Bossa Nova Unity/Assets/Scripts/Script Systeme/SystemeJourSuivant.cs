using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemeJourSuivant : MonoBehaviour
{

    [SerializeField] public bool prochainJour = false;
    [SerializeField] public int quelJour;
    [SerializeField] public ListesDialogues listes;
    [SerializeField] public GameManager gameManager;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        quelJour = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    public void UnjourdePlus()
    {
        quelJour += 1;
        Debug.Log(quelJour);
        prochainJour = true;
        Debug.Log(prochainJour);
        listes.numeroDialogue = 0;
        gameManager.jeuRevisionFini = false;
        gameManager.jeuBalaisFini = false;
    }
}
