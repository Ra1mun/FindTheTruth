using System;
using HeneGames.DialogueSystem;
using UnityEngine;

public class SpriteHandler
{

    private Sprite _sprite;
    public Sprite Sprite => _sprite;
    
    public void SetSprite(Sprite sprite)
    {
        _sprite = sprite;
    }
}
