using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schema : MonoBehaviour
{
    public POINTS[] points;
    public bool tableauFini;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Verification();
        TableauRempli();
    }



    private void Verification()
    {

        foreach (var point in points)
        {
            if (!point.estRelie) return;

        }

        tableauFini = true;
        
    }



    private void TableauRempli()
    {
        if (tableauFini)
        {
            for (int i = 0; i < points.Length-1; i++)
            {
                points[i].estRelie = false;
                 LigneConnection scriptLigneConnection;
                 LineRenderer connexion;
                
                 scriptLigneConnection = points[i].GetComponentInChildren<LigneConnection>();
                 Destroy(scriptLigneConnection);
                 connexion = points[i].GetComponentInChildren<LineRenderer>(); 
                 Destroy(connexion);
            }
            
            
        }
        
    }
}
