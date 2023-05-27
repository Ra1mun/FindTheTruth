using System;
using UnityEngine;
using Zenject;

public class MouseInput : IInput, ITickable
{
   public event Action<Vector2> OnInput;
   
   
   public void Tick()
   {
       OnInput?.Invoke(Input.mousePosition);
   }
}
