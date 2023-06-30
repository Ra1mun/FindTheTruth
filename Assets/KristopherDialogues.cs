using System;
using System.Collections;
using System.Collections.Generic;
using HeneGames.DialogueSystem;
using UnityEngine;

public class KristopherDialogues : MonoBehaviour
{
    [SerializeField] private DialogueManager _firstDialogue;
    [SerializeField] private DialogueManager _secondDialogue;

    private void Start()
    {
        if (DataHolder.ChangeDialogueKristopher)
        {
            _secondDialogue.gameObject.SetActive(true);
            _firstDialogue.gameObject.SetActive(false);
        }
    }
}
