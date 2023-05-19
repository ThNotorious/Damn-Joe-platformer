using System;
using UnityEngine;

public class PortalCreateZone : MonoBehaviour
{
    [SerializeField] private GameObject _portal;
    [SerializeField] private GameObject _textPressE;
    [SerializeField] private GameObject _textCollectParts;
    [SerializeField] private int _maxParts; //необходимое количество частей портала для его создания
    public int MaxParts => _maxParts;
    
    /// <summary>
    /// Событие, передающее количество собранных деталей в момент сбора очередной
    /// </summary>
    public  Action<int> AmountParts;

    private bool _isCollect;
    private bool _onTrigger;
    private int _amountCollecrParts = 0;


    #region Подписки на события
    private void OnEnable()
    {
        PortalParts.EventCollectPart += CheckCollect;
        PlayerInput.PressEButtonEvent += CreatePortal;
    }
    private void OnDisable()
    {
        PortalParts.EventCollectPart -= CheckCollect;
        PlayerInput.PressEButtonEvent -= CreatePortal;
    }
    #endregion


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _onTrigger = true;

        if (collision.gameObject.CompareTag(GlobalStringVars.PlayerTag))
        {
            if(_isCollect)
            {
                _textPressE.SetActive(true);
            }
            else
            {
                _textCollectParts.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _onTrigger = false;

        if (collision.gameObject.CompareTag(GlobalStringVars.PlayerTag))
        {
            _textPressE.SetActive(false); 
            _textCollectParts.SetActive(false);
        }
    }

    /// <summary>
    /// Проверка на сбор всех частей портала
    /// </summary>
    /// <param name="_amountPatrs"></param>
    private void CheckCollect()
    {
        _amountCollecrParts++;
        AmountParts.Invoke(_amountCollecrParts);

        if (_maxParts <= _amountCollecrParts) 
        {
            _isCollect = true;
        }
        else
        {
            _isCollect = false;
        }
    }

    /// <summary>
    /// Создание портала
    /// </summary>
    private void CreatePortal()
    {
        if(_onTrigger && _isCollect)
        {
            _portal.SetActive(true);
            _textPressE.SetActive(false);
        }
    }
}
