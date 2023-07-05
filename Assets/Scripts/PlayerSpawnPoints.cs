using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoints : MonoBehaviour
{
    [SerializeField] private Transform SamRoom;
    [SerializeField] private Transform Lobby;
    [SerializeField] private Transform Lab;
    [SerializeField] private Transform KristapherRoom;
    
    
    [SerializeField] private Transform _defualtPoint;
    public Vector3 GetPosition(string lastScene)
    {
        Transform position;
        switch (lastScene)
        {
            case "SamRoom":
                position = SamRoom;
                break;
            case "Lobby":
                position = Lobby;
                break;
            case "Lab":
                position = Lab;
                break;
            case "KristapherRoom":
                position = KristapherRoom;
                break;
            default:
                position = _defualtPoint;
                break;
        }

        if (position == null)
        {
            position = _defualtPoint;
        }

        return position.position;
    }
}
