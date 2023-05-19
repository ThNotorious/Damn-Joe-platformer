using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private PlayerHealth _health;
    [SerializeField] private Image _imageHealthBar;
    [SerializeField] private Sprite[] _spritesHealth;

    #region Подписки на события
    private void OnEnable()
    {
        _health.CurrentHealthEvent += WriteTextHealth;
    }
    private void OnDisable()
    {
        _health.CurrentHealthEvent -= WriteTextHealth;
    }
    #endregion

   /// <summary>
   /// Методменяющий UI компонент здоровья в зависимости от его изменения
   /// </summary>
   /// <param name="currenthp"></param>
    private void WriteTextHealth(int currenthp)
    {
        if (currenthp==5) 
        {
            _imageHealthBar.sprite = _spritesHealth[0];
        }
        else if(currenthp == 4)
        {
            _imageHealthBar.sprite = _spritesHealth[1];
        }
        else if (currenthp == 3)
        {
            _imageHealthBar.sprite = _spritesHealth[2];
        }
        else if (currenthp == 2)
        {
            _imageHealthBar.sprite = _spritesHealth[3];
        }
        else if (currenthp == 1)
        {
            _imageHealthBar.sprite = _spritesHealth[4];
        }
        else if (currenthp == 0)
        {
            _imageHealthBar.sprite = _spritesHealth[5];
        }
    }
}
