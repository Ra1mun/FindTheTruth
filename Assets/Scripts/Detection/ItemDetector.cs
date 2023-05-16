using System;
using UnityEngine;
using Zenject;

public class ItemDetector : IInitializable, IDisposable
{
    private readonly MouseInput _input;
    private readonly Camera _cam;

    public event Action<IItem> OnItemClicked;
    
    public ItemDetector(MouseInput input, Camera cam)
    {
        _input = input;
        _cam = cam;
    }
    
    public void Initialize()
    {
        _input.OnInput += OnInput;
    }
    
    private void OnInput(Vector2 position)
    {
        var worldPosition = _cam.ScreenToWorldPoint(position);
        var hit = Physics2D.Raycast(worldPosition, Vector2.down);
        
        if (hit.collider != null)
        {
            if (hit.collider.TryGetComponent<IItem>(out var item))
            {
                OnItemClicked?.Invoke(item);
            }
        }
    }
    
    public void Dispose()
    {
        _input.OnInput -= OnInput;
    }
}
