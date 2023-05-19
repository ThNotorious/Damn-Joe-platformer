using UnityEngine;


[CreateAssetMenu(fileName = "EnemyCharacteristics", menuName = "Gameplay/ Characters / New EnemyCharacteristics")]
public class EnemyCharacteristics : ScriptableObject
{
    [Header("EnemyAttack")]
    [SerializeField] private float _timerAttack = 0.7f;
    public float TimerAttack => _timerAttack;

   
    [Space, Header("EnemyDamage")]
    [SerializeField] private int _damageCount = 1;
    [SerializeField] private float _damageRange = 0.3f;
    [SerializeField] private LayerMask _attackMask;
    public int DamageCount => _damageCount;
    public float DamageRange => _damageRange;
    public LayerMask AttackMask => _attackMask;

    
    [Space, Header("EnemyState")]
    [SerializeField] private float _distanceToThePlayer = 2f;
    public float DistanceToThePlayer => _distanceToThePlayer;


    [Space, Header("EnemyPursuit")]
    [SerializeField] private float _speedPursuit = 0.3f;
    [SerializeField] private float _startAttakRange = 0.3f;
    public float SpeedPursuit => _speedPursuit;
    public float StartAttakRange => _startAttakRange;
    

    [Space, Header("EnemyPatrol")]
    [SerializeField] private float _speedPatrol = 0.3f;
    public float SpeedPatrol => _speedPatrol;


    [Space, Header("EnemyHealth")]
    [SerializeField] private int _healthMaxCount = 3;
    public int HealthMaxCount => _healthMaxCount;
}
