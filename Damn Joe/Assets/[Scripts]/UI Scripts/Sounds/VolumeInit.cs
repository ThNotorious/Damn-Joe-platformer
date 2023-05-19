using UnityEngine;
using UnityEngine.Audio;

public class VolumeInit : MonoBehaviour
{
    [SerializeField] string _volumParameter = "MasterVolume";
    [SerializeField] private AudioMixer _mixer;


    private void Start()
    {
        var volumeValue = PlayerPrefs.GetFloat(_volumParameter, _volumParameter == "Sound" ? -20f : -40f);
        _mixer.SetFloat(_volumParameter, volumeValue);
    }
}
