using UnityEngine;

public class EnemyNonPatrolState : EnemyState
{
    [SerializeField] private Collider2D _collider;

  
    /// <summary>
    /// Состояние непатрулирующего врага
    /// </summary>
    public override void State()
    {
        if (!_enemyDeath.IsDeath)
        {
            if (Vector2.Distance(_player.position, _rb.position) <= _enemyCharacteristics.DistanceToThePlayer)
            {
                _enemyPursuit.Pursuit(_player, _rb, _animator, _enemyCharacteristics);
                _collider.enabled = true;
            }
            else
            {
                _animator.SetTrigger("State");
                _collider.enabled = false;
            }
        }
    }
}
