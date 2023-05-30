using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IItem
{
    [SerializeField] private string _name;
    public string Name { get; set; }
    
    public void Interact(Player player)
    {
        if (!player.IsItemInInventory(_name))
        {
            player.AddItemInInventory(_name);
            Destroy(gameObject);
        }
    }
}
