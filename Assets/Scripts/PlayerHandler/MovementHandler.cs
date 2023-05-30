using System;

using UnityEngine;
using Zenject;

public class MovementHandler : IInitializable, IDisposable
{
    private Player _player;
    private KeyboardInput _input;

    public MovementHandler(Player player, KeyboardInput input)
    {
        _player = player;
        _input = input;
    }

    public void Initialize()
    {
        _input.OnInput += OnInput;
    }

    public void OnEnableInput()
    {
        _input.OnInput += OnInput;
    }

    private void OnInput(Vector2 direction)
    {
        _player.InitializeDirection(direction);
    }
    
    public void OnDisableInput()
    {
        _input.OnInput -= OnInput;
    }
    
    public void Dispose()
    {
        _input.OnInput -= OnInput;
    }
}
