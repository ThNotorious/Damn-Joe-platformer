using UnityEngine;


public class PlayerSounds : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _fireSound;//���� ��� ��������� �� ������
    [SerializeField] private AudioClip _jumpSound;//���� ��� ������
    [SerializeField] private AudioClip _damageSound;//���� ��� ��������� �����
    [SerializeField] private AudioClip _treatmentSound;//���� ��� �������
    [SerializeField] private AudioClip _deathSound;//���� ������


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
