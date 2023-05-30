using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class SceneEntry : MonoBehaviour
{
    [Inject] private Player _player;
    private void Start()
    {
        if (DataHolder.Player != null)
        {
            _player.Init(DataHolder.Player.Inventory);
        }
        DataHolder.Player = _player;
        DataHolder.LastScene = SceneManager.GetActiveScene().name;
    }
}
