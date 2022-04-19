using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class WichSchema : MonoBehaviour
{
   
    [SerializeField]
    public List<Schema> allschemas = new List<Schema>() ;
    
[SerializeField]
    private Schema[] schemaschoisis = new Schema[3];

    [SerializeField] 
    private List<Schema> allSchemaCopie = new List<Schema>();

    [SerializeField] private GestionFenetre fenetre;

    private int curseurSchema = 0;

    public Schema schemaFinal;

    public Schema schemaPrésentation;

    private bool jeuLance;
    private bool premierJeuLance = true;

    [SerializeField] BoiteDialogue dialogueMiniJeu;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
    premierJeuLance = true;
    }

    // Update is called once per frame
    void Update()
    {
        TableauEstFini();
    }

    public void ActivationRandom()

    {

        //StartCoroutine(LancementJeu());

        jeuLance = true;

       Schema schemasStock;

        allSchemaCopie = new List<Schema>(allschemas);

        for (int i = 0; i < schemaschoisis.Length; i++)
        {   
            schemasStock = allSchemaCopie[Random.Range(0, allSchemaCopie.Count)];
            allSchemaCopie.Remove(schemasStock);
            schemaschoisis[i] = schemasStock;
        }
        
       schemaschoisis[0].gameObject.SetActive(true);
        
    }

    

   public void TableauEstFini()
    {
        if (!jeuLance) return;

        if (schemaschoisis[curseurSchema].tableauFini)
        {
            Debug.Log("Le tableau est fini");
            schemaschoisis[curseurSchema].gameObject.SetActive(false);
            schemaschoisis[curseurSchema].tableauFini = false;
            curseurSchema++ ;

            if (curseurSchema >= schemaschoisis.Length)
            {
                jeuLance = false;
                TableauRinitialiser();
                StartCoroutine(FinJeu());
                //ecran victoire a lancer ici

            }

            else schemaschoisis[curseurSchema].gameObject.SetActive(true);
        }


    }

   public void TableauRinitialiser()

   {
       allSchemaCopie.Clear();
      // Array.Clear(schemaschoisis,0,schemaschoisis.Length);
   }

   public void LancementJeu()
   {

       StartCoroutine(SchemaLancement());


   }
   
  IEnumerator SchemaLancement()
   {
       if (premierJeuLance)
       {
           
          //Debug.Log("message presenttion");
           schemaPrésentation.gameObject.SetActive(true);
           yield return new WaitForSeconds(2);
           schemaPrésentation.gameObject.SetActive(false);
           schemaFinal.tableauFini = false;
           ActivationRandom();
           premierJeuLance = false;
       }
      
    else ActivationRandom();
       
   }


   IEnumerator FinJeu()
   {
       Debug.Log("fin jeu");
       schemaFinal.gameObject.SetActive(true);
       curseurSchema = 0;
       yield return new WaitForSeconds(2);
       schemaFinal.gameObject.SetActive(false);
       schemaFinal.tableauFini = false;
       fenetre.fenetreAnim.SetTrigger("Close");
       yield return new WaitForSeconds(1.8f);
       fenetre.fenetreObject.gameObject.SetActive(false);
   }
}


