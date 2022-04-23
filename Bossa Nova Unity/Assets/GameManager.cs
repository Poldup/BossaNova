using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public AudioMixer audioMixer
    public TransitionLevel changementLevel;
    
    public SystemeJourSuivant systemeJour;
    private float transitionTime  = 1f;
    
    
    
    
    public void JourSuivant()
    {
        
        StartCoroutine(ChangementJour());

    }

    IEnumerator ChangementJour()
    {
        yield return new WaitForSeconds(transitionTime);
            
    }
}
