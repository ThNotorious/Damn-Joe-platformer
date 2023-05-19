using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private WeaponCharacteristics characteristics;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(GlobalStringVars.DamageableTag))
        {
            collision.GetComponent<EnemyHealth>()?.TakeDamage(characteristics.Damage);
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GlobalStringVars.GroundTag))
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.Translate(characteristics.Speed * Time.deltaTime * Vector2.right);
    }
}
