using System;
using UnityEngine;
using Zenject;

public class InspectionHandler : IInitializable, IDisposable
{
    private readonly SpriteHandler _spriteHandler;
    private readonly ItemsHandler _itemsHandler;

    public event Action OnInspectionItem;

    public InspectionHandler(SpriteHandler spriteHandler, ItemsHandler itemsHandler)
    {
        _spriteHandler = spriteHandler;
        _itemsHandler = itemsHandler;
    }

    public void Initialize()
    {
        _itemsHandler.OnItemInspection += OnItem;
    }

    private void OnItem(InspectionItem item)
    {
        _spriteHandler.SetSprite(item.Sprite);
        OnInspectionItem?.Invoke();
    }
    
    public void Dispose()
    {
        _itemsHandler.OnItemInspection -= OnItem;
    }
}
