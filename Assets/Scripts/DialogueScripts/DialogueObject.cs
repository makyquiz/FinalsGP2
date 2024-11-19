using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue/DialogueObject")]
public class DialogueObject : ScriptableObject
{
    [SerializeField] private string[] charName;
    [SerializeField][TextArea] private string[] dialogue;
    [SerializeField] private Response[] responses; 

    public string[] CharName => charName;
    public string[] Dialogue => dialogue;

    public bool HasResponses => Responses != null && Responses.Length > 0;
    public Response[] Responses => responses;
}
