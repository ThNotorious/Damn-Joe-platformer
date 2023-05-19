using UnityEngine;

public class ParalaxController : MonoBehaviour
{
    [SerializeField] private Transform _followingTarget;
    [SerializeField, Range(0f, 1f)] private float _parallaxStrenth = 0.1f;
    [SerializeField] private bool _disableVerticalParalax;
   
    private Vector3 _targetPreviousPosition;


    private void Start()
    {
        if (!_followingTarget)
        {
            _followingTarget = Camera.main.transform;
        }
        _targetPreviousPosition = _followingTarget.position;
    }

    void Update()
    {
        var delta = _followingTarget.position - _targetPreviousPosition;

        if(_disableVerticalParalax)
        {
            delta.y = 0f;
        }

        _targetPreviousPosition = _followingTarget.position;

        transform.position += delta * _parallaxStrenth;
    }
}
