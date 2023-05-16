using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    [SerializeField] private Player _player;

    [SerializeField] private PlayerMovement _playerMovement;
    public override void InstallBindings()
    {
        BindInstance();
        BindInput();
        BindMovementSystem();
    }
    
    private void BindInstance()
    {
        Container.Bind<Player>().FromInstance(_player).AsSingle();
        Container.Bind<PlayerMovement>().FromInstance(_playerMovement).AsSingle();
    }

    private void BindInput()
    {
        Container.BindInterfacesAndSelfTo<KeyboardInput>().AsSingle();
    }

    private void BindMovementSystem()
    {
        Container.BindInterfacesAndSelfTo<PlayerMovementHandler>().FromNew().AsSingle();
    }
    
}