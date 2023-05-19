using System;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] private PlayerCharacteristics _playerCharacteristics;

    /// <summary>
    /// ������� ���������� ��� �������
    /// </summary>
    public Action TreatmentEvent;

    private void Awake()
    {
        _currentHealth = _playerCharacteristics.HealthMaxCount;
        CurrentHealthEvent?.Invoke(_currentHealth);
    }

    /// <summary>
    /// ����������� �������� ��� ��������� �������
    /// </summary>
    /// <param name="healthBoost"></param>
    public void Treatment(int healthBoost)
    {
        _currentHealth += healthBoost;

        if (_currentHealth > _playerCharacteristics.HealthMaxCount)
        {
            _currentHealth = _playerCharacteristics.HealthMaxCount;
        }
        else
        {
            TreatmentEvent?.Invoke();
        }

        CurrentHealthEvent?.Invoke(_currentHealth);
    }

    /// <summary>
    /// �������� �� ������� ������� ��������
    /// </summary>
    /// <returns></returns>
    public bool IsMaxHealthCheck()
    {
        return _currentHealth == _playerCharacteristics.HealthMaxCount;
    }
}
