using UnityEngine;

public class EnemyPursuit: MonoBehaviour
{
    [SerializeField] private EnemyLook _enemyLook;
    [SerializeField] private EnemyAttack _enemyAttack;

    /// <summary>
    /// Преследование игрока
    /// </summary>
    /// <param name="player"></param>
    /// <param name="rb"></param>
    /// <param name="animator"></param>
    /// <param name="enemyLook"></param>
    /// <param name="enemyAttack"></param>
    /// <param name="speedPursuit"></param>
    /// <param name="startAttakRange"></param>
    public void Pursuit(Transform player, Rigidbody2D rb, Animator animator, EnemyCharacteristics enemyCharacteristics)
    {
        _enemyLook.LookAtTarget(player);

        Vector2 target = new(player.position.x, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, enemyCharacteristics.SpeedPursuit * Time.deltaTime);

        if (Vector2.Distance(rb.position, player.position) >= enemyCharacteristics.StartAttakRange)
        {
            animator.SetTrigger("Pursuit");
            rb.MovePosition(newPos);
        }
        else
        {
            _enemyAttack.Attack(animator, enemyCharacteristics);
        }
    }
}
