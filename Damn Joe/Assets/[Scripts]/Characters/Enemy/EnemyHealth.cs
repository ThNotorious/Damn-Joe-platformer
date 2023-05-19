
public class EnemyHealth : Health
{
    public EnemyCharacteristics _enemyCharacteristics;

    private void Awake()
    {
        _currentHealth = _enemyCharacteristics.HealthMaxCount;
    }

}
