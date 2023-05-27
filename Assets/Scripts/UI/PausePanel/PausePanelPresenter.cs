public class PausePanelPresenter
{
    private readonly PausePanelModel _model;
    private readonly PausePanelView _view;

    public PausePanelPresenter(PausePanelModel model, PausePanelView view)
    {
        _model = model;
        _view = view;
    }

    public void Enable()
    {
        _view.OnPause += OnPause;
        _view.OnPlay += OnPlay;
    }

    private void OnPause()
    {
        _model.PauseGame();
        _view.Open();
    }

    private void OnPlay()
    {
        _view.Close();
        _model.PlayGame();
    }
    
    public void Disable()
    {
        _view.OnPause -= OnPause;
        _view.OnPlay -= OnPlay;
    }
}
