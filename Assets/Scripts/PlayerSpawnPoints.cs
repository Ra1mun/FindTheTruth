using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class PlayerSpawnPoints : MonoBehaviour
{
    private const int Lobby = 0;
    private const int Scene2 = 1;
    private const int Scene3 = 2;
    
    [SerializeField] private List<Transform> _spawnPoints = new List<Transform>();
    [SerializeField] private Transform _defualtPoint;
    public Vector3 GetPosition(string lastScene)
    {
        switch (lastScene)
        {
            case "Lobby":
                return _spawnPoints[Lobby].position;
            case "Scene2":
                return _spawnPoints[Scene2].position;
            case "Scene3":
                return _spawnPoints[Scene3].position;
            default:
                return _defualtPoint.position;
        }
    }
}
