using UnityEngine;

public abstract class EnemyState : MonoBehaviour
{
    [SerializeField] private protected EnemyCharacteristics _enemyCharacteristics;
    [SerializeField] private protected Transform _player;

    [SerializeField] private protected EnemyPursuit _enemyPursuit;
    [SerializeField] private protected EnemyDeath _enemyDeath;
    [SerializeField] private protected EnemyHealth _health;

    [SerializeField] private protected Rigidbody2D _rb;
    [SerializeField] private protected Animator _animator;


    private void FixedUpdate()
    {
        State();
    }

    /// <summary>
    /// Состояние врага
    /// </summary>
    public abstract void State();
}
