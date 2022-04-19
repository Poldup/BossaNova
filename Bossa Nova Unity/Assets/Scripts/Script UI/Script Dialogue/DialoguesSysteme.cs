using UnityEngine;
[CreateAssetMenu(menuName = "Dialogue/textes")]
public class DialoguesSysteme : ScriptableObject
{
    [SerializeField] [TextArea] private string[] dialogue;
    
    public string[] Dialogue => dialogue;



}
