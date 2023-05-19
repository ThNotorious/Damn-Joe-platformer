using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    /// <summary>
    /// ������� ���������� ��� ������� �������� �� 0
    /// </summary>
    public Action DeathEvent;
    /// <summary>
    /// ������� ���������� ��� ��������� �����
    /// </summary>
    public Action DamageEvent;
    /// <summary>
    /// ������� ������������ ������� ��������, ��� ��� ���������
    /// </summary>
    public Action<int> CurrentHealthEvent;

    private protected int _currentHealth;

    /// <summary>
    /// ���������� �������� ��� ��������� �����
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
