using System;
using UnityEngine;
using Zenject;

public class InspectionHandler : IInitializable, IDisposable
{
    private readonly SpriteHandler _spriteHandler;
    private readonly InspectionItemsHandler _inspectionItemsHandler;

    public event Action OnInspectionItem;

    public InspectionHandler(SpriteHandler spriteHandler, InspectionItemsHandler inspectionItemsHandler)
    {
        _spriteHandler = spriteHandler;
        _inspectionItemsHandler = inspectionItemsHandler;
    }

    public void Initialize()
    {
        _inspectionItemsHandler.OnItemInspection += OnItemInspection;
    }

    private void OnItemInspection(InspectionItem item)
    {
        _spriteHandler.SetSprite(item.Sprite);
        OnInspectionItem?.Invoke();
    }
    
    public void Dispose()
    {
        _inspectionItemsHandler.OnItemInspection -= OnItemInspection;
    }
}
