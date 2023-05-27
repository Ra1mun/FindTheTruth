using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class InspectionItemsHandler : MonoBehaviour
{
    [SerializeField] private List<InspectionItem> _inspectionItems;
    public event Action<InspectionItem> OnItemInspection;


    public void OnEnable()
    {
        foreach (var item in _inspectionItems)
        {
            item.OnInteracted += OnInteracted;
        }
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
