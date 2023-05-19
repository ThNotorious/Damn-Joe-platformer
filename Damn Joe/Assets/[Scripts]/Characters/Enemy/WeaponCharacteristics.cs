using UnityEngine;


[CreateAssetMenu(fileName = "WeaponCharacteristics", menuName = "Gameplay/ Weapons / New WeaponCharacteristics")]
public class WeaponCharacteristics : ScriptableObject
{
    [Header("TimerReloading")]
    [SerializeField] private float _timerReloading = 2.5f;
    public float TimerReloading => _timerReloading;


    [Space, Header("Damage")]
    [SerializeField] private int _damage = 1;
    public int Damage => _damage;

  
    [Space, Header("SpeedRun")]
    [SerializeField] private float _speed = 2.5f;
    public float Speed => _speed;

    [Space, Header("WeaponPrefab")]
    public GameObject WeaponPrefab; 
}
