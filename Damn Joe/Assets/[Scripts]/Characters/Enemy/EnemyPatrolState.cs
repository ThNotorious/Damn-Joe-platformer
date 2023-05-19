using UnityEngine;

public class EnemyPatrolState : EnemyState
{
    [SerializeField] private EnemyPatrol _enemyPatrol;


    /// <summary>
    /// Состояние врага
    /// </summary>
    public override void State()
    {
        if (!_enemyDeath.IsDeath)
        {
            if (Vector2.Distance(_player.position, _rb.position) <= _enemyCharacteristics.DistanceToThePlayer)
            {
                _enemyPursuit.Pursuit(_player, _rb, _animator, _enemyCharacteristics);
            }
            else
            {
                _enemyPatrol.Patrol(_animator, _enemyCharacteristics);
            }
        }
    }
}