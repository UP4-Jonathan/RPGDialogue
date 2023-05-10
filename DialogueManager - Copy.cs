using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
    public static DialogueManager Instance { get; set; }
    public List<string> dialogueLines = new List<string>();
    public GameObject dialoguePanel;

    string npcName;
    int dialoguePosition;
    Button continueButton;
    Text dialogueText, npcNameText;
    Image npcImage;


    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        continueButton = dialoguePanel.transform.Find("ContinueBtn").GetComponent<Button>();
        dialogueText = dialoguePanel.transform.Find("DialogueText").GetComponent<Text>();
        npcNameText = dialoguePanel.transform.Find("NamePanel").transform.Find("SpeakerName").GetComponent<Text>();
        npcImage = dialoguePanel.transform.Find("SpeakerImage").GetComponent<Image>();
        continueButton.onClick.AddListener(delegate { ContinueDialogue(); });
        dialoguePanel.SetActive(false);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddDialogue(string[] lines,string nName, Sprite nImage)
    {
        dialoguePosition = 0;
        dialogueLines.Clear();
        dialogueLines.AddRange(lines);
        npcName = nName;
        CreateDialogue(nImage);
        Debug.Log(dialogueLines.Count);
    }

    public void CreateDialogue(Sprite nImage)
    {
        dialogueText.text = dialogueLines[dialoguePosition];
        npcNameText.text = npcName;
        npcImage.sprite = nImage;
        DialogueManager.Instance.dialoguePanel.SetActive(true);
    }

    public void ContinueDialogue()
    {
        if(dialoguePosition < dialogueLines.Count - 1)
        {
            dialoguePosition++;
            dialogueText.text = dialogueLines[dialoguePosition];
        }
        else
        {
            dialoguePanel.SetActive(false);
        }
    }
}
