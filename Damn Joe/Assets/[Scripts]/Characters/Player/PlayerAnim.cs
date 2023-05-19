using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnim : MonoBehaviour
{
    private Animator _animator;
    private PlayerHealth _health;    

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _health = GetComponent<PlayerHealth>();
    }
    
    #region �������� �� �������
    private void OnEnable()
    {
        _health.DeathEvent += DeathAnimation;
        _health.TreatmentEvent += Treatment;
        _health.DamageEvent += TakingDamage;
        PlayerShooter.ShootEvent += ShootAnimation;
        PlayerController.JumpEvent += JumpAnimation;
        PlayerController.RunEvent += RunAnimation;
    }

    private void OnDisable()
    {
        _health.DeathEvent -= DeathAnimation;
        _health.TreatmentEvent -= Treatment;
        _health.DamageEvent -= TakingDamage;
        PlayerShooter.ShootEvent -= ShootAnimation;
        PlayerController.JumpEvent -= JumpAnimation;
        PlayerController.RunEvent -= RunAnimation;
    }
    #endregion

    /// <summary>
    /// �������� ����
    /// </summary>
    /// <param name="direction"></param>
    private void RunAnimation(bool isRun)
    {
        if (isRun)
        {
            _animator.SetBool("IsRunning", true);
        }
        else
        {
            _animator.SetBool("IsRunning", false);
        }
    }

    /// <summary>
    /// �������� ������
    /// </summary>
    private void JumpAnimation()
    {
        _animator.SetTrigger("Jump");
    }

    /// <summary>
    /// �������� ��� �������� �� ��������
    /// </summary>
    /// <param name="obj"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void OnLadderAnimation(bool inMove)
    {
        _animator.SetBool("OnLadder", inMove);
    }
  
    /// <summary>
    /// �������� ������
    /// </summary>
    private void DeathAnimation()
    {
        _animator.SetTrigger("Death");
    }

    /// <summary>
    /// �������� ��������
    /// </summary>
    private void ShootAnimation()
    {
        _animator.SetTrigger("Shoot");
    }

    /// <summary>
    /// �������� ��������� �����
    /// </summary>
    private void TakingDamage()
    {
        _animator.SetTrigger("Damage");
    } 
    
    /// <summary>
    /// �������� �������
    /// </summary>
    private void Treatment()
    {
        _animator.SetTrigger("Treatment");
    }
}