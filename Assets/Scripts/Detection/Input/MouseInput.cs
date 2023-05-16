using System;
using UnityEngine;
using Zenject;

public class MouseInput : IInput, ITickable
{
   public event Action<Vector2> OnInput;
   private const int LeftMouseButton = 0;
   
   public void Tick()
   {
      if (Input.GetMouseButtonDown(LeftMouseButton))
      {
         OnInput?.Invoke(Input.mousePosition);
      }
   }
}
