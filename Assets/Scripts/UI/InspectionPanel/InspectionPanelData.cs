using UnityEngine;

public class InspectionPanelData
{
    private readonly SpriteHandler _spriteHandler;

    public Sprite Sprite => _spriteHandler.Sprite;
    
    public InspectionPanelData(SpriteHandler spriteHandler)
    {
        _spriteHandler = spriteHandler;
    }
}
