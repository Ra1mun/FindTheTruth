using System;

using UnityEngine;
using Zenject;

public class PlayerMovementHandler : IInitializable, IDisposable
{
    private PlayerMovement _playerMovement;
    private KeyboardInput _input;

    public PlayerMovementHandler(PlayerMovement playerMovement, KeyboardInput input, Player player)
    {
        _input = input;
        _playerMovement = playerMovement;
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
        _playerMovement.Move(direction);
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
