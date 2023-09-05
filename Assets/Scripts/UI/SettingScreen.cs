using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingScreen : UIScreen
{
    [SerializeField] Slider m_soundSlider;
    [SerializeField] Slider m_musicSlider;
    [SerializeField] Button m_increaseButton;
    [SerializeField] Button m_decreaseButton;

    private int m_characterVisualID = 0;

    public void OnSoundSliderValueChange()
    {
        Debug.LogWarning("OnSoundSliderValueChange: " + m_soundSlider.value);

        SoundManager.Instance.SetSoundState(m_soundSlider.value);
    }
    public void OnMusicSliderValueChange()
    {
        Debug.LogWarning("OnMusicSliderValueChange: " + m_musicSlider.value);

        SoundManager.Instance.SetMusicState(m_musicSlider.value);
    }
    public void OnIncreaseButtonPressed()
    {
        m_characterVisualID = Mathf.Clamp(m_characterVisualID + 1, 0, 3);
        MenuManager.Instance.SetCharacterVisualID(m_characterVisualID);
    }
    public void OnDecreaseButtonPressed()
    {
        m_characterVisualID = Mathf.Clamp(m_characterVisualID - 1, 0, 3);
        MenuManager.Instance.SetCharacterVisualID(m_characterVisualID);
    }
    public void OnBackButtonPressed()
    {
        SoundManager.Instance.PlaySound("Click");
        MenuManager.Instance.BackToHome();
    }
}
