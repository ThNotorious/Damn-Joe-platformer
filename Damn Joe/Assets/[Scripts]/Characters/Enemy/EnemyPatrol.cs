using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform _pointLeft;
    [SerializeField] private Transform _pointRight;
    [SerializeField] private EnemyLook _enemyLook;
    
    private Transform _target;


    private void Start()
    {
        _target = _pointLeft;
    }

    /// <summary>
    /// Патрулирование определенной области
    /// </summary>
    /// <param name="animator"></param>
    public void Patrol(Animator animator, EnemyCharacteristics enemyCharacteristics)
    {
        _enemyLook.LookAtTarget(_target);

        animator.SetTrigger("Patrol");
        transform.position = Vector2.MoveTowards(transform.position, _target.position, enemyCharacteristics.SpeedPatrol * Time.deltaTime);

        if(Vector2.Distance(transform.position, _pointLeft.position) < 0.2f)
        {
            _target = _pointRight;
        }
        else if(Vector2.Distance(transform.position, _pointRight.position) < 0.2f)
        {
            _target = _pointLeft;
        }
    }
}

