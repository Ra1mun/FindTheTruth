using UnityEngine;
using Zenject;

public class ItemInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        BindDetection();
        BindGeneral();
        BindInventorySystem();
        BindInput();
        BindSprite();
        BindItemHandler();
    }

    private void BindItemHandler()
    {
        Container.Bind<ItemsHandler>().FromNew().AsSingle();
        Container.BindInterfacesAndSelfTo<InspectionHandler>().FromNew().AsSingle();
    }
    
    private void BindInventorySystem()
    {
        Container.BindInterfacesAndSelfTo<ItemClickHandler>().FromNew().AsSingle();
    }
    
    private void BindInput()
    {
        Container.BindInterfacesAndSelfTo<MouseInput>().AsSingle();
        Container.BindInterfacesAndSelfTo<InputHandler>().FromNew().AsSingle();
    }
    
    private void BindGeneral()
    {
        Container.Bind<Camera>().FromInstance(Camera.main).AsSingle();
        Container.Bind<TimeState>().FromNew().AsSingle();
    }
    
    private void BindDetection()
    {
        Container.BindInterfacesAndSelfTo<ItemDetector>().FromNew().AsSingle();
    }

    private void BindSprite()
    {
        Container.Bind<SpriteHandler>().FromNew().AsSingle();
    }
}