using UnityEngine;
using Zenject;

public class ItemHighlightHandler : MonoBehaviour
{
    [SerializeField] private Panel _panel;
    [Inject] private ItemDetector _itemDetector;
    
    private void OnEnable()
    {
        _itemDetector.OnItemBrought += OnItemBrought;
    }

    private void OnItemBrought(IItem item)
    {
        if (item == GetComponent<IItem>())
        {
            _panel.ShowPanel();
        }
        else
        {
            _panel.ClosePanel();
        }
    }

    private void OnDisable()
    {
        _itemDetector.OnItemBrought -= OnItemBrought;
    }
}