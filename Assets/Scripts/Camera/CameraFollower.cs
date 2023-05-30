using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class CameraFollower : MonoBehaviour
{
    [Inject] private Player _target;

    private Vector3 velocity;
    
    private void FixedUpdate()
    {
        var targetPosition = new Vector3(_target.transform.position.x, _target.transform.position.y, -10);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 0.18f, 40);
    }
}
