using System;
using System.Collections;
using System.Collections.Generic;
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

    private int curseurSchema = 0;

    public Schema schemaFinal;

    private bool jeuLance;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TableauEstFini();
    }

    public void ActivationRandom()

    {
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
            schemaschoisis[curseurSchema].gameObject.SetActive(false);
            schemaschoisis[curseurSchema].tableauFini = false;
            curseurSchema++ ;

            if (curseurSchema >= schemaschoisis.Length)
            {
                schemaFinal.gameObject.SetActive(true);
                jeuLance = false;
                curseurSchema = 0;
                
                TableauRinitialiser();
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
}


