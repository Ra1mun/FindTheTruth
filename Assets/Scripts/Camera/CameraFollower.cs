using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector3 velocity;
    
    private void FixedUpdate()
    {
        var targetPosition = new Vector3(_target.position.x, _target.position.y, -10);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 0.18f, 40);
    }
}
