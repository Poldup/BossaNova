using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class EffetTexte : MonoBehaviour
{
    [SerializeField] private float vitesse = 50f;
    public Coroutine Effet(string textToType, TMP_Text text)
    {
        return StartCoroutine(TexteEffet(textToType, text));
    }

    private IEnumerator TexteEffet(string textToType, TMP_Text text)
    {
        text.text = string.Empty;
        float t = 0;
        int persoIndex = 0;

        while (persoIndex < textToType.Length)
        {
            t += Time.deltaTime * vitesse;
            persoIndex = Mathf.FloorToInt(t);
            persoIndex = Mathf.Clamp(persoIndex, 0,textToType.Length);

            text.text = textToType.Substring(0, persoIndex);
            yield return null;
        }

        text.text = textToType;
    }


}
