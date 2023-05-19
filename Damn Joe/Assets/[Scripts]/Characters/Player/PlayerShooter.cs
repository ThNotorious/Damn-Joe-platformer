using System;
using System.Collections;
using UnityEngine;


public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private WeaponCharacteristics characteristics;
    [SerializeField] private Transform _shotDirecton;

    /// <summary>
    /// Событие вызываемое во время выстрела
    /// </summary>
    public static Action ShootEvent;
   
    private bool _isTimeShoot = true;


    #region Подписки на события
    private void OnEnable()
    {
        PlayerInput.PressLeftButtonMouseEvent += Shoot;
        PlayerInput.CursorPosition += BowRotation;
    }

    private void OnDisable()
    {
        PlayerInput.PressLeftButtonMouseEvent -= Shoot;
        PlayerInput.CursorPosition -= BowRotation;
    }
    #endregion

    /// <summary>
    /// Вращение лука, в зависимости от положения курсора
    /// </summary>
    private void BowRotation(Vector3 difference)
    {
        difference -= transform.position; // положение курсора относительно игрока
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        #region Ограничения вращения лука в зависимости от поворота игрока
        if (PlayerController.IsRight)
        {
            if (rotateZ >= 75) rotateZ = 75;
            if (rotateZ <= -20) rotateZ = -20;

            transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);
        }
        else if (!PlayerController.IsRight)
        {
            if (rotateZ <= -20) rotateZ = 200;
            if (rotateZ <= 105) rotateZ = 105;

            transform.rotation = Quaternion.Euler(180f, 0f, -rotateZ);
        }
        #endregion
    }

    /// <summary>
    /// Выстрел
    /// </summary>
    private void Shoot()
    {
        if (!_isTimeShoot) return; // если перезарядка не закончена, отменить выстрел 

        ShootEvent?.Invoke();
        Instantiate(characteristics.WeaponPrefab, _shotDirecton.position, transform.rotation); //Создание новой стрелы
       
        _isTimeShoot=false;
        StartCoroutine(Timer()); //Запуск перезарядки
    }

    /// <summary>
    /// Таймер перезарядки
    /// </summary>
    /// <returns></returns>
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(characteristics.TimerReloading);
       _isTimeShoot = true;
    }
}

