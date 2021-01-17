using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volSlider;
    [SerializeField] Slider difSlider;

    float defaultValue = 0.8f;

    private void Start()
    {
        volSlider.value = PlayerPrefsController.GetMasterVolume();
    }

    private void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if(musicPlayer)
        {
            musicPlayer.SetVolume(volSlider.value);
            PlayerPrefsController.SetMasterVolume(volSlider.value);
        }
    }

}
