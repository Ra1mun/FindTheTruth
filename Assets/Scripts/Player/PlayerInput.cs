using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerInput : MonoBehaviour
{
    [Inject] private readonly InputHandler _input;

    public void DisableInput()
    {
        _input.DisableInput();
    }

    public void EnableInput()
    {
        _input.EnableInput();
    }
}
