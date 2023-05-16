using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public GameObject GameObject;
    private GameObject _gameObject;

    private void Awake()
    {
        _gameObject = GetComponent<GameObject>();
    }

    private Example(GameObject gameObject)
    {
        _gameObject = gameObject;
    }
}
