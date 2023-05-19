using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthUI : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private EnemyHealth _enemyHealth;


    #region Подписки на события
    private void OnEnable()
    {
        _enemyHealth.CurrentHealthEvent += HealthUI;
    }
    private void OnDisable()
    {
        _enemyHealth.CurrentHealthEvent -= HealthUI;
    }
    #endregion
   
    private void Awake()
    {
        _slider.maxValue = _enemyHealth._enemyCharacteristics.HealthMaxCount;
        _slider.value = _slider.maxValue;
    }

    private void HealthUI(int currentHealth)
    {
        _slider.value = currentHealth;
    }
}
