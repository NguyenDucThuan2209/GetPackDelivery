using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingScreen : UIScreen
{
    [SerializeField] Slider m_soundSlider;
    [SerializeField] Slider m_musicSlider;

    public void OnSoundSliderValueChange()
    {
        Debug.LogWarning("OnSoundSliderValueChange: " + m_soundSlider.value);
    }
    public void OnMusicSliderValueChange()
    {
        Debug.LogWarning("OnMusicSliderValueChange: " + m_musicSlider.value);
    }
    public void OnBackButtonPressed()
    {
        SoundManager.Instance.PlaySound("Click");
        MenuManager.Instance.BackToHome();
    }
}
