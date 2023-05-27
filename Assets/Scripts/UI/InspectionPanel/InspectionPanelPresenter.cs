using UnityEngine;

public class InspectionPanelPresenter
{
    private readonly InspectionPanelModel _model;
    private readonly InspectionPanelView _view;
    private readonly InspectionPanelData _data;

    public InspectionPanelPresenter(InspectionPanelModel model, InspectionPanelView view, InspectionPanelData data)
    {
        _model = model;
        _view = view;
        _data = data;
    }

    public void Enable()
    {
        _model.Enable();
        _model.OnInspection += OnInspection;
        _view.OnClose += OnClose;
    }

    private void OnInspection()
    {
        _view.Open();
        _view.Set(_data.Sprite);
    }
    
    private void OnClose()
    {
        _model.ClosePanel();
        
        _view.Close();
        _view.Set(null);
    }

    public void Disable()
    {
        _view.OnClose -= OnClose;
    }
}
