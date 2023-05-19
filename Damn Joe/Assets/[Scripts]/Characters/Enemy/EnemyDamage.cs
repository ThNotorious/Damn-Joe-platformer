using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private EnemyCharacteristics _enemyCharacteristics;

    private Vector3 _attackoffset;

    /// <summary>
    /// Метод, вызываемый в анимации атаки
    /// </summary>
    public void Damage()
    {
        Vector3 pos = transform.position;
        pos += transform.right * _attackoffset.x;
        pos += transform.up * _attackoffset.y;

        Collider2D colinfo = Physics2D.OverlapCircle(pos, _enemyCharacteristics.StartAttakRange, _enemyCharacteristics.AttackMask);

        if(colinfo != null)
        {
            colinfo.GetComponent<PlayerHealth>().TakeDamage(_enemyCharacteristics.DamageCount);
        }
    }
}
