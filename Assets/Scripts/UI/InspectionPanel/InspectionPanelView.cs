using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class InspectionPanelView : MonoBehaviour
{
    [SerializeField] private Button _closeButton;
    [SerializeField] private Image _image;

    private CanvasGroup _canvasGroup;

    public Action OnClose;

    private void OnEnable()
    {
        _closeButton.onClick.AddListener(OnCloseClick);
    }

    private void OnCloseClick()
    {
        OnClose?.Invoke();
    }

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    public void Open()
    {
        _canvasGroup.Open();
    }

    public void Close()
    {
        _canvasGroup.Close();
    }

    public void Set(Sprite sprite)
    {
        _image.sprite = sprite;
    }

    private void OnDisable()
    {
        _closeButton.onClick.RemoveListener(OnCloseClick);
    }
}
