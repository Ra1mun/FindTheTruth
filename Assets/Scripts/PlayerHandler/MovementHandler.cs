using System;

using UnityEngine;
using Zenject;

public class MovementHandler : IInitializable, IDisposable
{
    private PlayerMovement _playerMovement;
    private PlayerAnimation _playerAnimation;
    private KeyboardInput _input;

    public MovementHandler(PlayerMovement playerMovement, PlayerAnimation playerAnimation, KeyboardInput input)
    {
        _playerMovement = playerMovement;
        _playerAnimation = playerAnimation;
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
        _playerMovement.Move(direction);
        _playerAnimation.AnimateMove(direction);
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
