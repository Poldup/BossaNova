using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustCounter : MonoBehaviour
{
    public List<GameObject> Dusts;
    public static DustCounter instance;
    [SerializeField] private GameManager manager;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Dusts.Count==0)
        {
            Debug.Log("finito");
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
