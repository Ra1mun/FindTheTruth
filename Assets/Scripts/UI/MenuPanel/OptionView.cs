using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionView : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Button _CloseButton;

    private void OnEnable()
    {
        _CloseButton.onClick.AddListener(OnCloseClick);
    }

    private void OnCloseClick()
    {
        _canvasGroup.Close();
    }

    private void OnDisable()
    {
        _CloseButton.onClick.RemoveListener(OnCloseClick);
    }
}
