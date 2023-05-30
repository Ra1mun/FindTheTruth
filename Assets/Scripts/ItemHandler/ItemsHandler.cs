using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ItemsHandler
{
    private List<InspectionItem> _inspectionItems = new List<InspectionItem>();
    public event Action<InspectionItem> OnItemInspection;


    public void Add(InspectionItem item)
    {
        _inspectionItems.Add(item);

        item.OnInteracted += OnInteracted;
    }

    private void OnInteracted(InspectionItem item)
    {
        
        OnItemInspection?.Invoke(item);
        Remove(item);
    }

    private void Remove(InspectionItem item)
    {
        item.OnInteracted -= OnInteracted;
        _inspectionItems.Remove(item);
    }
    
    public void OnDisable()
    {
        foreach (var item in _inspectionItems)
        {
            item.OnInteracted -= OnInteracted;
        }
    }
}
