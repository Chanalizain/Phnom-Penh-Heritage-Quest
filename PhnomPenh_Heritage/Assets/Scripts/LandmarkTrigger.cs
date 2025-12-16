//it tells the QuizMANAGER to start the specific quiz linked to each landmark
using UnityEngine;

public class LandmarkTrigger : MonoBehaviour
{
    public QuizManager manager;

    // Drag the specific QuizData asset here 
    public QuizData quizToStart;

    void Start()
    {
        // Find the single instance of the QuizManager in the scene
        manager = FindObjectOfType<QuizManager>();

        if (manager == null)
        {
            Debug.LogError("FATAL ERROR: Could not find QuizManager component in the scene! Make sure it is attached to a GameObject.");
        }
    }
    private void OnMouseDown()
    {
        StartLandmarkQuiz();
    }

    // This function can be called by a Button, a Collider (trigger), or another script
    public void StartLandmarkQuiz()
    {
        if (manager != null && quizToStart != null)
        {
            manager.StartQuiz(quizToStart);
        }
        else
        {
            Debug.LogError("Trigger setup is incomplete: Manager or QuizData is missing!");
        }
    }
}