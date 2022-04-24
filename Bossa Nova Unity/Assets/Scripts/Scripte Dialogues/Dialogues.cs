using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogues/DialoguesObjets")]

public class Dialogues : ScriptableObject
{

    [SerializeField] [TextArea] private string[] phrase;
    public bool dialogueFini = false;

    public string[] DialoguesObjet => phrase;
}
