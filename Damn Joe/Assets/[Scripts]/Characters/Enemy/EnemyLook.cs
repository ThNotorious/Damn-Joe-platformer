using System;
using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    public Action<bool> RightEvent;
    private bool _isFlipped;

    private void Start()
    {
        RightEvent?.Invoke(_isFlipped);
    }

    /// <summary>
    /// Поворот врага в сторону игрока
    /// </summary>
    public void LookAtTarget(Transform obj)
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if(transform.position.x > obj.position.x && _isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            _isFlipped = false;
        }
        else if(transform.position.x < obj.position.x && !_isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            _isFlipped = true;
        }
        RightEvent?.Invoke(_isFlipped);
    }
}
