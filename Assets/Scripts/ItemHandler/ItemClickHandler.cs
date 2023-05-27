using System;
using UnityEngine;
using Zenject;

public class ItemClickHandler : IInitializable, IDisposable
{
    private ItemDetector _itemDetector;
    private Player _player;
    private const int LeftMouseButton = 0;
    
    public ItemClickHandler(ItemDetector itemDetector, Player player)
    {
        _itemDetector = itemDetector;
        _player = player;
    }

    public void Initialize()
    {
        _itemDetector.OnItemBrought += OnItemBrought;
    }

    public void OnEnableInput()
    {
        _itemDetector.OnItemBrought += OnItemBrought;
    }

    private void OnItemBrought(IItem item)
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            item.Interact(_player);
        }
    }
    
    public void OnDisableInput()
    {
        _itemDetector.OnItemBrought -= OnItemBrought;
    }

    public void Dispose()
    {
        _itemDetector.OnItemBrought -= OnItemBrought;
    }
}
