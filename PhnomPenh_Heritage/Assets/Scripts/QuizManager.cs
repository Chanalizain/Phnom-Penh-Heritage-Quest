using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class QuizManager : MonoBehaviour
{
    public HeritageSpot currentSpot;
    public GameObject[] options;
    private int questionIndex = 0;

    // score tracking
    private int correctAnswers = 0;

    public Text QuestionTxt;
    public GameObject quizUI;    // The Panel for the quiz
    public GameObject resultUI;  // A Panel to show the result
    public Text resultText;      // Text on the result panel

    public void GoToMap()
    {
        SceneManager.LoadScene("SampleScene"); // Change "MapScene" to your actual map scene name
    }

    public void RestartQuiz()
    {
        // Reloads the current scene to try the quiz again
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // We will call this from our Map when we click a building
    public void StartQuiz(HeritageSpot spot)
    {
        currentSpot = spot;
        questionIndex = 0;
        correctAnswers = 0;

        quizUI.SetActive(true);
        resultUI.SetActive(false);

        ShuffleList(currentSpot.questions);
        generateQuestion();
    }

    void Awake() 
    {
        if (HeritageSpot.selectedSpot == null)
        {
            Debug.LogError("QUIZ: Data is NULL! The handshake failed.");
        }
        // High-priority check
        if (HeritageSpot.selectedSpot != null)
        {
            Debug.Log("Success! Found data for: " + HeritageSpot.selectedSpot.spotName);
            StartQuiz(HeritageSpot.selectedSpot);
        }
    }

    void ShuffleList(List<QuestionAndAnswers> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            QuestionAndAnswers temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

    public void correct()
    {
        correctAnswers++; // Count the correct answer
        questionIndex++;
        generateQuestion();
    }

    // Add this for wrong answers so the quiz continues
    public void wrong()
    {
        questionIndex++;
        generateQuestion();
    }

    void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = currentSpot.questions[questionIndex].Answers[i];

            if (currentSpot.questions[questionIndex].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<Answer>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if (questionIndex < currentSpot.questions.Count)
        {
            QuestionTxt.text = currentSpot.questions[questionIndex].Question;
            SetAnswer();
        }
        else
        {
            FinishQuiz();
        }
    }

    void FinishQuiz()
    {
        quizUI.SetActive(false);
        resultUI.SetActive(true);

        // 80% Logic
        float scorePercent = ((float)correctAnswers / currentSpot.questions.Count) * 100f;

        if (scorePercent >= 80f)
        {
            resultText.text = "Passed!\n" + scorePercent + "%\nBadge Earned!";
            // Save the badge to the device
            PlayerPrefs.SetInt(currentSpot.spotName, 1);
            PlayerPrefs.Save();
        }
        else
        {
            resultText.text = "Failed!\n" + scorePercent + "%\nYou need 80% to earn the badge.";
        }
    }

   
}
