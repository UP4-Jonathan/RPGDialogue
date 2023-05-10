using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Tools/Dialogue/New Dialogue")]
public class Dialogue : ScriptableObject
{
    [SerializeField] private List<DialogueNode> nodes = new List<DialogueNode>();
    public List<DialogueNode> Nodes => nodes;

}

[System.Serializable]
public class DialogueNode
{
    [SerializeField] private string text;
    [SerializeField] private List<DialogueOption> options = new List<DialogueOption>();

    public string Text => text;
    public List<DialogueOption> Options => options;
}

[System.Serializable]
public class DialogueOption
{
    [SerializeField] private string text;
    [SerializeField] private DialogueNode response;
    [SerializeField] private UnityEvent onSelected;
    public string Text => text;
    public DialogueNode Response => response;
    public UnityEvent OnSelected => onSelected;


}
