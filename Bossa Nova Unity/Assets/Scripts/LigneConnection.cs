using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(LineRenderer))]
public class LigneConnection : MonoBehaviour
{
    [SerializeField]
    private LineRenderer connexion;

    public static bool enTrainDeFaireUneLigne;

    private POINTS prochainPoint;
    private bool nepasSuivre;
    private bool plusieursLignes;

    private int nbrLignes = 0;
    
    public UnityEvent quandRelie = new UnityEvent();

    public Schema schema;

    public POINTS pointActif;

    private void OnValidate()
    {
        if (!connexion && TryGetComponent(out connexion))
        {
            
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       SuivreSouris(prochainPoint);
        //AnnulerLigne();
        VerifierProchainPoint();
       UneSeuleLigne();
    }

    private void VerifierProchainPoint()
    {
        if (Input.GetMouseButtonUp(0) && !nepasSuivre)
        {
           // print("Appuie sur le bouton");
            Collider2D pointSuivant = Physics2D.OverlapCircle(Camera.main.ScreenToWorldPoint(Input.mousePosition),0.05f);
           nbrLignes = nbrLignes + 1;
           print(nbrLignes);
            if (pointSuivant && pointSuivant.TryGetComponent(out POINTS cercle ) && cercle == prochainPoint)
            {
                
                // print("Normalement le point est relie");
                RelierPoints();

            }

        }
    }

    private void RelierPoints()
    {
        connexion.SetPosition(1,prochainPoint.transform.position);
        nepasSuivre = true;
        enTrainDeFaireUneLigne = true;
        quandRelie.Invoke();
        

    }
    public void SuivreSouris(POINTS pointDepart)
    {
        if (nepasSuivre) return;
        connexion.SetPosition(1, (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition));
        if (Input.GetMouseButton(1) && !pointDepart.estRelie)
        {
            pointDepart.estRelie = false;
            Destroy(gameObject);

        }
    }

    public void PositionPoints(POINTS premierPoint, POINTS _prochainPoint)
    {
        connexion.SetPosition(0,(Vector2) premierPoint.transform.position);
        nepasSuivre = false ;
        prochainPoint = _prochainPoint;
        enTrainDeFaireUneLigne = true;
    }

  /*  public void AnnulerLigne()
    {
        if (!nepasSuivre && Input.GetMouseButton(1))
        {
            enTrainDeFaireUneLigne = false;
            Destroy(gameObject);
        }
        
    }*/

    public void UneSeuleLigne()
    {
        if (nbrLignes > 2)
        {
           // nepasSuivre = false;
           // enTrainDeFaireUneLigne = false;
           Destroy(gameObject);
           

        }
        
        
    }
    
}
