using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private Dialogue dialogue;
    [SerializeField] private TextMesh dialogueText;
    [SerializeField] private Button[] optionButtons;
    private DialogueNode currentNode;

    // Start is called before the first frame update
    void Start()
    {
        ShowNode(dialogue.Nodes[0]);        
    }

    private void ShowNode(DialogueNode dialogueNode)
    {
        currentNode = dialogueNode;
        dialogueText.text = currentNode.Text;

        for(int i = 0; i < optionButtons.Length; i++)
        {
            if(i < currentNode.Options.Count)
            {
                optionButtons[i].gameObject.SetActive(true);
                optionButtons[i].GetComponentInChildren<Text>().text = currentNode.Options[i].Text;
                int index = i;
                optionButtons[i].onClick.AddListener(() => { SelectOption(index); });
            }
            else
            {
                optionButtons[i].gameObject.SetActive(false);
            }
        }
    }

    private void SelectOption(int index)
    {
        DialogueOption selectedOption = currentNode.Options[index];
        selectedOption.OnSelected.Invoke();

        DialogueNode response = currentNode.Options[index].Response;
        ShowNode(response);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
