﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionItem : Interactable {

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Base Action Item");
    }

}