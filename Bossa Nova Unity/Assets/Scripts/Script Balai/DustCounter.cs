using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustCounter : MonoBehaviour
{
    public List<GameObject> Dusts;
    public GameObject bienOuej;
    public static DustCounter instance;
    public GameObject modele;
    [SerializeField] private GameManager manager;
    [HideInInspector]
    public bool started=false;
    
    public WichSchema wichSchema;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Dusts.Count == 0 && started)
        {
            Debug.Log("finito");
            StartCoroutine(wichSchema.GetComponent<WichSchema>().FinJeu());
            manager.jeuBalaisFini = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Dusts.Contains(collision.gameObject))
        {
            Dusts.Remove(collision.gameObject);
        }
    }
}
