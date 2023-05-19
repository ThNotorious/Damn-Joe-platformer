using UnityEngine;

public class HealthBooster : MonoBehaviour
{
    [SerializeField] private int _healthBoost = 1;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerHealth health))
        {
            if (health.IsMaxHealthCheck()) return;
            
            health.Treatment(_healthBoost);
       
            Destroy(gameObject);
        }
    }
}
    