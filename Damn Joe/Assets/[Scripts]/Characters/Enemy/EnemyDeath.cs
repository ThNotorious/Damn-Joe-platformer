using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
   [SerializeField] private EnemyHealth _enemyHealth;
   [SerializeField] private Animator _animator;
   [SerializeField] private Collider2D _collider;

    public bool IsDeath {get; private set;}


    #region Подписки на события
    private void OnEnable()
    {
        _enemyHealth.DeathEvent += Death;
    }

    private void OnDisable()
    {
        _enemyHealth.DeathEvent -= Death;
    }
    #endregion

    private void Death()
    {
        IsDeath = true;
        _collider.enabled = false;
        _animator.SetTrigger("Death");
    }

}
