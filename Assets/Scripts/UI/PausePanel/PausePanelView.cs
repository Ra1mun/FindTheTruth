using System;
using UnityEngine;
using UnityEngine.UI;

public class PausePanelView : MonoBehaviour
{
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _playButton;

    private CanvasGroup _canvasGroup;

    public event Action OnPause;
    public event Action OnPlay;

    private void OnEnable()
    {
        _pauseButton.onClick.AddListener(OnPauseClick);
        _playButton.onClick.AddListener(OnPlayClick);
    }

    private void OnPauseClick()
    {
        OnPause?.Invoke();
    }

    private void OnPlayClick()
    {
        OnPlay?.Invoke();
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

    private void OnDisable()
    {
        _playButton.onClick.RemoveListener(OnPlayClick);
    }
    
}
