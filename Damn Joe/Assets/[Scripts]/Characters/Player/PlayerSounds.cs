using UnityEngine;


public class PlayerSounds : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _fireSound;//звук при наведении на кнопку
    [SerializeField] private AudioClip _jumpSound;//звук при прыжке
    [SerializeField] private AudioClip _damageSound;//звук при получении урона
    [SerializeField] private AudioClip _treatmentSound;//звук при лечении
    [SerializeField] private AudioClip _deathSound;//звук смерти


    public void JumpSound()
    {
        _audioSource.PlayOneShot(_jumpSound);
    }
    public void ShootSound()
    {
        _audioSource.PlayOneShot(_fireSound);
    }
    public void DamageSound()
    {
        _audioSource.PlayOneShot(_damageSound);
    } 
    public void DeathSound()
    {
        _audioSource.PlayOneShot(_deathSound);
    }
    public void TreatmentSound()
    {
        _audioSource.PlayOneShot(_treatmentSound);
    } 
}
