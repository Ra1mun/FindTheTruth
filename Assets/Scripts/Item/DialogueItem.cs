using System;
using System.Collections;
using System.Collections.Generic;
using HeneGames.DialogueSystem;
using UnityEngine;

public class DialogueItem : MonoBehaviour, IItem
{
    [SerializeField] private string _name;
    [SerializeField] private bool DestroyAfterClick;
    private DialogueManager _dialogue;
    public string Name { get; set; }
    

    private void Awake()
    {
        _dialogue = GetComponent<DialogueManager>();
    }

    public void Interact(Player player)
    {
        DialogueUI.instance.StartDialogue(_dialogue);
        if (!player.IsItemInInventory(_name) && DestroyAfterClick)
        {
            player.AddItemInInventory(_name);
            Destroy(gameObject);
        }
    }
}
