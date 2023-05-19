using System;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;

    /// <summary>
    /// Событие, возникающее при нажатии на левую клавишу мыши
    /// </summary>
    public static Action PressLeftButtonMouseEvent;
    
    /// <summary>
    /// Событие, возникающее при нажатии на клавишу 'E'
    /// </summary>
    public static Action PressEButtonEvent;
    
    /// <summary>
    /// Событие, возникающее при нажатии на клавишу 'Esc'
    /// </summary>
    public static Action PressEscButtonEvent;

    /// <summary>
    /// Событие передающее координаты нахождения курсора на экране
    /// </summary>
    public static Action<Vector3> CursorPosition;

    private float _horizontalDirection;
    private bool _isJumpButtonPressed;


    private void Update()
    {
        _horizontalDirection = Input.GetAxisRaw(GlobalStringVars.HorizontalAxis);
        _isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars.JumpButton);

        playerController.Move(_horizontalDirection, _isJumpButtonPressed);

        CursorPosition?.Invoke(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        
        if (Input.GetButtonDown(GlobalStringVars.Fire1))
        {
            PressLeftButtonMouseEvent?.Invoke();
        }
        if (Input.GetButtonDown(GlobalStringVars.Interaction))
        {
            PressEButtonEvent?.Invoke();
        } 
        if (Input.GetButtonDown(GlobalStringVars.Cancel))
        {
            PressEscButtonEvent?.Invoke();
        }
    }
}
