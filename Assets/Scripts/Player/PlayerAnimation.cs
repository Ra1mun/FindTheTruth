using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    
    public void AnimateMove(Vector2 direction)
    {
        _animator.SetFloat("Vertical", direction.y);
        _animator.SetFloat("Horizontal", direction.x);
        _animator.SetFloat("Speed", direction.magnitude);
    }
}
