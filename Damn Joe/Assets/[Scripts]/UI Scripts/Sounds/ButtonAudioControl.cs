using UnityEngine;

public class ButtonAudioControl : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _pointingAudio;//���� ��� ��������� �� ������
    [SerializeField] private AudioClip _clickudio;//���� ��� ������� �� ������

    public void PointingSound()
    {
        _audioSource.PlayOneShot(_pointingAudio);
    }  
    
    public void ClickSound()
    {
        _audioSource.PlayOneShot(_clickudio);
    }
}
