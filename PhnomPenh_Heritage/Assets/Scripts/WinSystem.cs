using UnityEngine;
using UnityEngine.UI;

public class BadgeInventory : MonoBehaviour
{
    public HeritageSpot[] allSpots; // Drag all your Spot objects here
    public GameObject winScreen;    // A UI panel that says "You Win!"
    public Text counterText;

    public void CheckWinCondition()
    {
        int totalBadges = 0;
        foreach (HeritageSpot spot in allSpots)
        {
            // Check PlayerPrefs for each spot name
            if (PlayerPrefs.GetInt(spot.spotName, 0) == 1)
            {
                totalBadges++;
            }
        }

        if (counterText != null)
        {
            counterText.text = "Badges: " + totalBadges + " / " + allSpots.Length;
        }

        if (totalBadges >= allSpots.Length)
        {
            winScreen.SetActive(true);
        }
    }
    void Start()
    {
        CheckWinCondition(); // Automatically check for win whenever player returns to map
    }
}
