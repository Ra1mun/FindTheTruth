using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MasterVolumeUI : MonoBehaviour
{
    private Slider _slider;
    [SerializeField] private AudioMixer _mixer;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(UpdateVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(UpdateVolume);
    }

    private void UpdateVolume(float value)
    {
        _mixer.SetFloat("Master", value);
    }
}
