﻿using UnityEngine;
using Zenject;

public class PausePanelSetup : MonoBehaviour
{
    [SerializeField] private PausePanelView _view;

    [SerializeField] private PausePanelPresenter _presenter;
    private PausePanelModel _model;

    [Inject]
    private void Constructor(TimeState timeState, InputHandler inputHandler)
    {
        _model = new PausePanelModel(timeState, inputHandler);
        _presenter = new PausePanelPresenter(_model, _view);
    }

    private void OnEnable()
    {
        _presenter.Enable();
    }

    private void OnDisable()
    {
        _presenter.Disable();
    }
}
