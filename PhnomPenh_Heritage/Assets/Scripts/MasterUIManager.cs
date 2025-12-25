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
}