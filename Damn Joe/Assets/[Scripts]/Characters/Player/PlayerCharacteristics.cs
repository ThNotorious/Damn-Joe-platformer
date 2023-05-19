using UnityEngine;


[CreateAssetMenu(fileName = "PlayerCharacteristics", menuName = "Gameplay/ Characters / New PlayerCharacteristics")]
public class PlayerCharacteristics : ScriptableObject
{
    [Header("PlayerController")]
    [SerializeField] private float _speedRun;
    [SerializeField] private float _jumpForce;
    [SerializeField] private int _collisionLayer = 6;
    public float SpeedRun => _speedRun;
    public float JumpForce => _jumpForce;
    public int CollisionLayer => _collisionLayer;


    [Space, Header("PlayerHealth")]
    [SerializeField] private int _healthMaxCount = 5;
    public int HealthMaxCount => _healthMaxCount;
}
