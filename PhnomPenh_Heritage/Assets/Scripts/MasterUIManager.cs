using UnityEngine;
using UnityEngine.UI;

public class MasterUIManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public Slider volumeSlider;
    public BadgeInventory badgeInv;

    [Header("Badge Settings")]
    public Image[] badgeUIImages; // Drag your 3 UI Images here
    public Color lockedColor = new Color(0.3f, 0.3f, 0.3f, 0.5f); // Grey/Transparent
    public Color unlockedColor = Color.white; // Full Color

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        UpdateVisuals();
    }

    public void CloseSettings() => settingsPanel.SetActive(false);

    public void UpdateVisuals()
    {
        // Loop through the spots defined in your BadgeInventory
        for (int i = 0; i < badgeInv.allSpots.Length; i++)
        {
            string nameToCheck = badgeInv.allSpots[i].spotName;

            // Check if the badge is earned (1 = earned)
            if (PlayerPrefs.GetInt(nameToCheck, 0) == 1)
            {
                badgeUIImages[i].color = unlockedColor; // Bright/Visible
            }
            else
            {
                badgeUIImages[i].color = lockedColor; // Faded/Grey
            }
        }
    }
    public void SetVolume(float value)
    {
        // AudioListener.volume controls EVERY sound in the entire game (0.0 to 1.0)
        AudioListener.volume = value;

        // Optional: Save the volume so it stays the same when you switch scenes
        PlayerPrefs.SetFloat("MasterVolume", value);
    }

    void Start()
    {
        // When the scene starts, load the saved volume
        float savedVolume = PlayerPrefs.GetFloat("MasterVolume", 1.0f);
        if (volumeSlider != null)
        {
            volumeSlider.value = savedVolume;
        }
        AudioListener.volume = savedVolume;
    }
    //click sound
    [Header("SFX Settings")]
    public AudioSource sfxSource; // A separate AudioSource for clicks
    public AudioClip clickSound;  // Drag your click .mp3 or .wav here

    public void PlayClickSound()
    {
        if (sfxSource != null && clickSound != null)
        {
            // PlayOneShot allows sounds to overlap without cutting each other off
            sfxSource.PlayOneShot(clickSound);
        }
    }
}