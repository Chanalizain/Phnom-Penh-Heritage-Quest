using UnityEngine;
using UnityEngine.SceneManagement;

public class LearningSceneController : MonoBehaviour
{
    // This function will be called by your button
    public void ClickStartQuiz()
    {
        SceneManager.LoadScene("QuizScene"); 
    }

    public void BackToMap()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    void Start()
    {
        if (HeritageSpot.selectedSpot != null)
        {
            Debug.Log("STEP 2 SUCCESS: Data reached Learning Scene: " + HeritageSpot.selectedSpot.spotName);
        }
        else
        {
            Debug.LogError("STEP 2 FAIL: Data was lost BEFORE reaching Learning Scene!");
        }
    }
}