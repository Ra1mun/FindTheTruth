using System;
using UnityEngine;
using Zenject;

public class ItemHighlightHandler : MonoBehaviour
{
    [SerializeField] private Panel _panel;
    [Inject] private MouseInput _mouseInput;
    [Inject] private Camera _cam;

    private void OnEnable()
    {
        _mouseInput.OnInput += ItemHighlight;
    }

    private void ItemHighlight(Vector2 position)
    {
        var worldPosition = _cam.ScreenToWorldPoint(position);
        var hit = Physics2D.Raycast(worldPosition, Vector2.down);
        
        if (hit.collider != null)
        {
            if (hit.collider.GetComponent<IItem>() == GetComponent<IItem>())
            {
                _panel.ShowPanel();
            }
            else
            {
                _panel.ClosePanel();
            }
        }
    }

    private void OnDisable()
    {
        _mouseInput.OnInput -= ItemHighlight;
    }
}