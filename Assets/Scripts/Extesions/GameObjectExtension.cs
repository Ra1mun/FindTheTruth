using System;
using UnityEngine;

public static class GameObjectExtension 
{
    public static void Route<T>(this Collider2D container, Action<T> handler)
    {
        if (container != null)
        {
            if (container.TryGetComponent<T>(out var col))
            {
                handler?.Invoke(col);
            }
        }
    }
}
