
using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _growSpeed;
    private void Update()
    {
        Vector3 DirectionGrow = _growSpeed * Time.deltaTime * Vector3.one;
        transform.localScale += DirectionGrow;
    }
}
