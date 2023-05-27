using UnityEngine;

public class InputHandler
{
    private readonly ItemClickHandler _itemClickHandler;
    private readonly MovementHandler _movementHandler;

    public InputHandler(ItemClickHandler itemClickHandler, MovementHandler movementHandler)
    {
        _itemClickHandler = itemClickHandler;
        _movementHandler = movementHandler;
    }

    public void EnableInput()
    {
        _itemClickHandler.OnEnableInput();
        _movementHandler.OnEnableInput();
    }
    
    public void DisableInput()
    {
        _itemClickHandler.OnDisableInput();
        _movementHandler.OnDisableInput();
    }

    
}

