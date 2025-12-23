using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildingTrigger : MonoBehaviour
{
    public HeritageSpot mySpotData;

    private void OnMouseDown()
    {
        if (mySpotData == null)
        {
            Debug.LogError("ERROR: No data assigned to this building's BuildingTrigger script!");
            return;
        }

        // 1. Assign to the static variable
        HeritageSpot.selectedSpot = mySpotData;

        // 2. Double check right here
        Debug.Log("Building Clicked! Data saved: " + HeritageSpot.selectedSpot.spotName);

        // 3. Load scene
        SceneManager.LoadScene("QuizScene"); // Ensure this name is exactly right
    }
}