using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPanelView : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _optionButton;

    private void OnEnable()
    {
        _playButton.onClick.AddListener(OnPlayClick);
        _optionButton.onClick.AddListener(OnOptionClick);
    }

    private void OnOptionClick()
    {
        _canvasGroup.Open();
    }

    private void OnPlayClick()
    {
        SceneManager.LoadScene("SamRoom");
    }

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(OnPlayClick);
        _optionButton.onClick.RemoveListener(OnOptionClick);
    }
}
