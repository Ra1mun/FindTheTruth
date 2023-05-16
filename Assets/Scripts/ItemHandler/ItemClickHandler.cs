using System;
using UnityEngine;
using Zenject;

public class ItemClickHandler : IInitializable, IDisposable
{
    private ItemDetector _itemDetector;
    private Player _player;
    
    public ItemClickHandler(ItemDetector itemDetector, Player player)
    {
        _itemDetector = itemDetector;
        _player = player;
    }

    public void Initialize()
    {
        _itemDetector.OnItemClicked += OnItemClicked;
    }

    public void OnEnableInput()
    {
        _itemDetector.OnItemClicked += OnItemClicked;
    }

    private void OnItemClicked(IItem item)
    {
        item.Interact(_player);
    }
    
    public void OnDisableInput()
    {
        _itemDetector.OnItemClicked -= OnItemClicked;
    }

    public void Dispose()
    {
        _itemDetector.OnItemClicked -= OnItemClicked;
    }
}
