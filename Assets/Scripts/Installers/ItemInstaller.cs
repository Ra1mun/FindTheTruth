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
    }
    
    private void BindInventorySystem()
    {
        Container.BindInterfacesAndSelfTo<ItemClickHandler>().FromNew().AsSingle();
    }
    
    private void BindInput()
    {
        Container.BindInterfacesAndSelfTo<MouseInput>().AsSingle();
    }
    
    private void BindGeneral()
    {
        Container.Bind<Camera>().FromInstance(Camera.main).AsSingle();
    }
    
    private void BindDetection()
    {
        Container.BindInterfacesAndSelfTo<ItemDetector>().FromNew().AsSingle();
    }
}