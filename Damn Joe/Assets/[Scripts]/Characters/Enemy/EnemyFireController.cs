using UnityEngine;

public class EnemyFireController : MonoBehaviour
{
    [SerializeField] private WeaponCharacteristics characteristics;
    [SerializeField] private Rigidbody2D _rb;
    private GameObject _playerTarget;


    private void Start()
    {
        _playerTarget = GameObject.FindGameObjectWithTag(GlobalStringVars.PlayerHeadTag);

        Vector3 _moveDirection = _playerTarget.transform.position - transform.position;
        _rb.velocity = new Vector2 (_moveDirection.x, _moveDirection.y).normalized * characteristics.Speed;

        float rotate = Mathf.Atan2(-_moveDirection.y, -_moveDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 180, rotate + 30f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GlobalStringVars.PlayerTag))
        {
            collision.gameObject.GetComponent<PlayerHealth>()?.TakeDamage(characteristics.Damage);
        }
        Destroy(gameObject);
    }
}
