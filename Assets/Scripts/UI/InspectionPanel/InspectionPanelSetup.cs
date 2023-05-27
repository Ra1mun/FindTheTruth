using UnityEngine;
using Zenject;

public class InspectionPanelSetup : MonoBehaviour
{
    [SerializeField] private InspectionPanelView _view;

    private InspectionPanelPresenter _presenter;
    private InspectionPanelModel _model;
    private InspectionPanelData _data;

    [Inject]
    private void Constructor(TimeState timeState, InspectionHandler inspectionHandler, SpriteHandler spriteHandler,
        InputHandler inputHandler)
    {
        _data = new InspectionPanelData(spriteHandler);
        _model = new InspectionPanelModel(inputHandler, timeState, inspectionHandler);
        _presenter = new InspectionPanelPresenter(_model, _view, _data);
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
