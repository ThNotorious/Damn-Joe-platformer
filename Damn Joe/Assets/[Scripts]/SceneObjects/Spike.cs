using UnityEngine;

public class Spike : MonoBehaviour
{
    private int _damage = 50;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerHealth>()?.TakeDamage(_damage);
    }
}
