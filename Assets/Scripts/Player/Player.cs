using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    [SerializeField] private List<string> _inventory = new List<string>();
    public List<string> Inventory => _inventory;
    
    private PlayerAnimation _playerAnimation;
    private PlayerMovement _playerMovement;
    
    
    public void Init(List<string> inventory)
    {
        _inventory = inventory;
    }
    
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

    private void Awake()
    {
        _playerAnimation = GetComponent<PlayerAnimation>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    public void InitializeDirection(Vector2 direction)
    {
        _playerAnimation.AnimateMove(direction);
        _playerMovement.Move(direction);
    }
}
