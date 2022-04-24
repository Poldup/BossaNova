using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class PenSoundSelector : MonoBehaviour
{
    private int premSound;
    private int sound;
    public static PenSoundSelector instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        premSound = UnityEngine.Random.Range(0, 15);
        sound = premSound;
    }

    public void Pen()
    {
        transform.GetChild(sound).GetComponent<AudioSource>().Play();
        sound += 1;
        if (sound==16)
        {
            sound = 0;
        }
        
    }
}
