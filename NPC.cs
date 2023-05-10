using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable {
    public string[] dialogue;
    public string npcName;
    public Sprite npcImage;

    public override void Interact()
    {
        base.Interact();
        DialogueManager.Instance.AddDialogue(dialogue,npcName,npcImage);
        Debug.Log("NPC Class");
    }
   
}
