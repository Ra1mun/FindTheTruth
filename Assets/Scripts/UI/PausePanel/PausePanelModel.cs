public class PausePanelModel
{
    private readonly TimeState _timeState;
    private readonly InputHandler _input;
    public PausePanelModel(TimeState timeState, InputHandler input)
    {
        _input = input;
        _timeState = timeState;
    }

    public void PlayGame()
    {
        _input.EnableInput();
        _timeState.Resume();
    }

    public void PauseGame()
    {
        _input.DisableInput();
        _timeState.Stop();
    }
}
