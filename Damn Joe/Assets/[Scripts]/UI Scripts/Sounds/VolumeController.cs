using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] string _volumParameter = "MasterVolume";
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private Slider _slider;

    private float _volumeValue;
    private const float _multiplier = 20f;
    

    private void Awake()
    {
        _slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(_volumParameter, _volumeValue);
    }

    private void Start()
    {
        _volumeValue = PlayerPrefs.GetFloat(_volumParameter, MathF.Log10(_slider.value) * _multiplier);
        _slider.value = Mathf.Pow(10f, _volumeValue / _multiplier);
    }


    private void HandleSliderValueChanged(float value)
    {
        _volumeValue = MathF.Log10(value) * _multiplier;
        _mixer.SetFloat(_volumParameter, _volumeValue);
    }

}
