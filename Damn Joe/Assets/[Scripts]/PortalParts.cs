using System;
using UnityEngine;

public class PortalParts : MonoBehaviour
{
    /// <summary>
    /// ������� ���������� � ������ ������� ����� ������� � ������������ ����� ���������� ����������� ������
    /// </summary>
    public static Action EventCollectPart;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(GlobalStringVars.PlayerTag))
        {
            EventCollectPart.Invoke();
            Destroy(gameObject);
        }
    }
}
