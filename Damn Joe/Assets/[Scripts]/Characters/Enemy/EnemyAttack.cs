using System.Collections;
using UnityEngine;

public class EnemyAttack: MonoBehaviour
{
    private bool _isTimeAttack = true;

    /// <summary>
    /// �����
    /// </summary>
    public void Attack(Animator animator, EnemyCharacteristics characteristics)
    {
        if (!_isTimeAttack) return; // ���� ����������� �� ���������, �������� �����

        animator.SetTrigger("Attack");
        
        _isTimeAttack = false;
        StartCoroutine(Timer(animator, characteristics.TimerAttack)); //������ �����������
    }

    /// <summary>
    /// ������ ������ ����� ������
    /// </summary>
    /// <returns></returns>
    private IEnumerator Timer(Animator animator, float timerAttack)
    {
        animator.SetTrigger("Idle");
        yield return new WaitForSeconds(timerAttack);
        _isTimeAttack = true;
    }
}
