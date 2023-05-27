using System;
using UnityEngine;
using Zenject;

public class KeyboardInput : IInput, IFixedTickable
{
    public event Action<Vector2> OnInput; 
    
    public void FixedTick()
    {
        var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        OnInput?.Invoke(direction);
    }
}
