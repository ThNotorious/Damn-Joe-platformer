using UnityEngine;

public class EnemyRangedAttack : MonoBehaviour
{
    [SerializeField] private WeaponCharacteristics characteristics;
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _fireDirecton;

    public void Fire()
    {
        Instantiate(characteristics.WeaponPrefab, _fireDirecton.position, transform.rotation); //Создание огня
    }
}
