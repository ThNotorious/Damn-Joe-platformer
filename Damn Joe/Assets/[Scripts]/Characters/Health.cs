using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    /// <summary>
    /// Событие вызываемое при падении здоровья до 0
    /// </summary>
    public Action DeathEvent;
    /// <summary>
    /// Событие вызываемое при получении урона
    /// </summary>
    public Action DamageEvent;
    /// <summary>
    /// Событие возвращающее текущее здоровье, при его изменении
    /// </summary>
    public Action<int> CurrentHealthEvent;

    private protected int _currentHealth;

    /// <summary>
    /// Уменьшение здоровья при получении урона
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            DeathEvent?.Invoke();
            _currentHealth = 0;
        }
        else
        {
            DamageEvent?.Invoke();
        }
      
        CurrentHealthEvent?.Invoke(_currentHealth);
    }
}
