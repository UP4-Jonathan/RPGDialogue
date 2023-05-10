using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SignPost : ActionItem {

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Sign Post");
    }
}
