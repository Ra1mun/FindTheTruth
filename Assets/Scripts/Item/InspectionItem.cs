using System;
using UnityEngine;
using Zenject;

public class InspectionItem : MonoBehaviour, IItem
{
    [SerializeField] private string _name;
    [SerializeField] private Sprite _sprite;

    public Sprite Sprite => _sprite;
    
    public event Action<InspectionItem> OnInteracted;
    
    public void Interact(Player player)
    {
        OnInteracted?.Invoke(this);

        if (!player.IsItemInInventory(_name))
        {
            player.AddItemInInventory(_name);
            Destroy(gameObject);
        }
    }
}