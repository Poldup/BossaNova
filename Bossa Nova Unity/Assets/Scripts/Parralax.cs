using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralax : MonoBehaviour
{

private float longueur, posDebut;
public Camera cameraJeu;
public float parralax;

private float posCamera;


    // Start is called before the first frame update
    void Start()
    {
        
        posDebut = transform.position.x;
        longueur = GetComponent<SpriteRenderer>().bounds.size.x;
        posCamera = cameraJeu.transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        


        float temp = (cameraJeu.transform.position.x * (1 - parralax));
        float distance = (cameraJeu.transform.position.x * parralax);

        transform.position = new Vector3(posDebut + distance, transform.position.y, transform.position.z);

        if (temp > posDebut + longueur)
        {
            posDebut += longueur;
        }
        
        else if (temp < posDebut - longueur)
        {
            posDebut -= longueur;
        }
    }
}
