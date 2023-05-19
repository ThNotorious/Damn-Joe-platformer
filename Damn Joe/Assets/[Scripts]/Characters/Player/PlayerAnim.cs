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
    
    #region Подписки на события
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
    /// Анимация бега
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
    /// Анимация прыжка
    /// </summary>
    private void JumpAnimation()
    {
        _animator.SetTrigger("Jump");
    }

    /// <summary>
    /// Анимация при движении по лестнице
    /// </summary>
    /// <param name="obj"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void OnLadderAnimation(bool inMove)
    {
        _animator.SetBool("OnLadder", inMove);
    }
  
    /// <summary>
    /// Анимация смерти
    /// </summary>
    private void DeathAnimation()
    {
        _animator.SetTrigger("Death");
    }

    /// <summary>
    /// Анимация Выстрела
    /// </summary>
    private void ShootAnimation()
    {
        _animator.SetTrigger("Shoot");
    }

    /// <summary>
    /// Анимация получения урона
    /// </summary>
    private void TakingDamage()
    {
        _animator.SetTrigger("Damage");
    } 
    
    /// <summary>
    /// Анимация лечения
    /// </summary>
    private void Treatment()
    {
        _animator.SetTrigger("Treatment");
    }
}