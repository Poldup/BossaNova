using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionFixe : MonoBehaviour
{

    private LineRenderer ligne;

    public GameObject boutonOrigine;
    public GameObject boutonSuivant;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Connectionboutons();
        // ligne = this.GetComponent<LineRenderer>();
      
    }


    public void Connectionboutons()
    {
        ligne = GetComponentInParent<LineRenderer>();
        ligne.SetPosition(0, new Vector3(boutonOrigine.transform.position.x, boutonOrigine.transform.position.y, 0));
        ligne.SetPosition(1,new Vector3(boutonSuivant.transform.position.x, boutonSuivant.transform.position.y,0));
        
    }
}
