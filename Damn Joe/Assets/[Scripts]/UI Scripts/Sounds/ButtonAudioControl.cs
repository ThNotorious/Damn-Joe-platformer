using UnityEngine;

public class ButtonAudioControl : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _pointingAudio;//звук при наведении на кнопку
    [SerializeField] private AudioClip _clickudio;//звук при нажатии на кнопку

    public void PointingSound()
    {
        _audioSource.PlayOneShot(_pointingAudio);
    }  
    
    public void ClickSound()
    {
        _audioSource.PlayOneShot(_clickudio);
    }
}
