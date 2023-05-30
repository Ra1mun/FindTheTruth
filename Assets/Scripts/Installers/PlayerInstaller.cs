using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerSpawnPoints _spawnPoints;
    public override void InstallBindings()
    {
        BindInstance();
        BindInput();
        BindMovementSystem();
        
    }
    
    private void BindInstance()
    {
        var playerInstance =
            Container.InstantiatePrefabForComponent<Player>(_player, _spawnPoints.GetPosition(DataHolder.LastScene),
                Quaternion.identity, null);
        Debug.Log(DataHolder.LastScene);
        Container.Bind<Player>().FromInstance(playerInstance).AsSingle();
    }

    private void BindInput()
    {
        Container.BindInterfacesAndSelfTo<KeyboardInput>().AsSingle();
    }

    private void BindMovementSystem()
    {
        Container.BindInterfacesAndSelfTo<MovementHandler>().FromNew().AsSingle();
    }
    
}