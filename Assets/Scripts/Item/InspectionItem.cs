using System;
using UnityEngine;
using Zenject;

public class InspectionItem : MonoBehaviour, IItem
{
    [Inject] private ItemsHandler _itemsHandler;
    [SerializeField] private string _name;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private bool DestroyAfterClick;
    public string Name { get; set; }
    
    public Sprite Sprite => _sprite;
    
    public event Action<InspectionItem> OnInteracted;

    private void OnEnable()
    {
        _itemsHandler.Add(this);
    }

    public void Interact(Player player)
    {
        OnInteracted?.Invoke(this);

        if (!player.IsItemInInventory(_name) && DestroyAfterClick)
        {
            player.AddItemInInventory(_name);
            _itemsHandler.Remove(this);
            Destroy(gameObject);
        }
    }
}