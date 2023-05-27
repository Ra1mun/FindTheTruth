using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    [SerializeField] private List<string> _inventory = new List<string>();

    public bool IsItemInInventory(string itemName)
    {
        return _inventory.Contains(itemName);
    }

    public void RemoveItemFromInventory(string itemName)
    {
        _inventory.Remove(itemName);
    }
    
    public void AddItemInInventory(string itemName)
    {
        _inventory.Add(itemName);
    }
}
