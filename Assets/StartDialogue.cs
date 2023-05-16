using System;
using System.Collections;
using System.Collections.Generic;
using HeneGames.DialogueSystem;
using UnityEngine;

public class StartDialogue : MonoBehaviour
{
    private void Start()
    {
        DialogueUI.instance.StartDialogue(GetComponent<DialogueManager>());
    }
}
