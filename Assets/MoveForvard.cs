
using UnityEngine;

public class MoveForvard : MonoBehaviour
{
    [SerializeField] private Vector3 _moveDirection = Vector3.forward;
    private float _speed = 0.1f;
    
    void Update()
    {
        transform.Translate(_moveDirection*_speed);
    }
}
