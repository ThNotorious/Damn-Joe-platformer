using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerCharacteristics _playerCharacteristics;
    [SerializeField] private Rigidbody2D _rb;

    /// <summary>
    /// Событие вызываемое при прыжке
    /// </summary>
    public static Action JumpEvent;
    /// <summary>
    /// Событие вызываемое при беге
    /// </summary>
    public static Action <bool> RunEvent;
    public static bool IsRight { get; private set; } = true;
    private bool _isGrounded;


    /// <summary>
    /// Проверка на коллизию с землей
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == _playerCharacteristics.CollisionLayer)
        {
            _isGrounded = true;
        }
    }

    /// <summary>
    /// Обрботка движения персонажа
    /// </summary>
    /// <param name="direction"></param>
    /// <param name="isJumpButtonPressed"></param>
    public void Move(float direction, bool isJumpButtonPressed)
    {
        if (isJumpButtonPressed && _isGrounded)
        {
            Jump();
        }

        if (direction != 0)
        {
            RunEvent?.Invoke(true);
            HorizontalMovement(direction);
            Turn(direction);
        }
        else
        {
            RunEvent?.Invoke(false);
        }
    }

    /// <summary>
    /// Поворот персонажа в зависимости от направления движения
    /// </summary>
    /// <param name="direction"></param>
    private void Turn(float direction)
    {
        if (direction < 0)
        {
            IsRight = false;
            _rb.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (direction > 0)
        {
            IsRight = true;
            _rb.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    /// <summary>
    /// Прыжок
    /// </summary>
    public void Jump()
    {
        JumpEvent?.Invoke();
        _rb.velocity = new Vector2(_rb.velocity.x, _playerCharacteristics.JumpForce);
        _isGrounded = false; 
    }

    /// <summary>
    /// Движение персонажа
    /// </summary>
    /// <param name="direction"></param>
    private void HorizontalMovement(float direction)
    {
        _rb.velocity = new Vector2(direction * _playerCharacteristics.SpeedRun, _rb.velocity.y);
    }
}
