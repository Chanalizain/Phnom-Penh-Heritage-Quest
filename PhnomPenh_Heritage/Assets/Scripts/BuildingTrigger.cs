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
        HeritageSpot.selectedSpot = mySpotData;
        Debug.Log("MAP: Saving data for " + mySpotData.spotName);

        Debug.Log("Building Clicked! Data saved: " + HeritageSpot.selectedSpot.spotName);

        SceneManager.LoadScene(mySpotData.learningSceneName); // Ensure this name is exactly right
    }

    
}