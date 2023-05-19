using System;
using UnityEngine;

public class PortalParts : MonoBehaviour
{
    /// <summary>
    /// Событие вызываемое в момент подбора части портала и возвращающее общее количество подобранных частей
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
