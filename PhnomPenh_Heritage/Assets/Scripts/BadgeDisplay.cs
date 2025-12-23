using UnityEngine;

public class BadgeDisplay : MonoBehaviour
{
    public string spotName; // Type "WatPhnom" exactly like your ScriptableObject name

    void Start()
    {
        // Check if this specific badge was saved in PlayerPrefs
        if (PlayerPrefs.GetInt(spotName, 0) == 1)
        {
            gameObject.SetActive(true); // Show the badge!
        }
        else
        {
            gameObject.SetActive(false); // Hide the badge!
        }
    }
}