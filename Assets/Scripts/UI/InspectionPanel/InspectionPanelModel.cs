using System;

public class InspectionPanelModel
{
    private readonly InputHandler _input;
    private readonly TimeState _timeState;
    private readonly InspectionHandler _inspectionHandler;
    
    public InspectionPanelModel(InputHandler input, TimeState timeState, InspectionHandler inspectionHandler)
    {
        _input = input;
        _timeState = timeState;
        _inspectionHandler = inspectionHandler;
    }

    public event Action OnInspection;

    public void Enable()
    {
        _inspectionHandler.OnInspectionItem += OnInspectionItem;
    }
    
    public void OnInspectionItem()
    {
        _timeState.Stop();
        _input.DisableInput();
        OnInspection?.Invoke();
    }

    public void ClosePanel()
    {
        _timeState.Resume();
        _input.EnableInput();
    }

    public void Disable()
    {
        _inspectionHandler.OnInspectionItem -= OnInspectionItem;
    }
}
