

// QuizManager.cs
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using TMPro;

public class QuizManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject quizPanel;
    // CRITICAL: Drag the CanvasGroup component from your quizPanel here in the Inspector!
    public CanvasGroup quizPanelCanvasGroup;
    public TextMeshProUGUI questionTextUI;
    public TextMeshProUGUI quizProgressText;

    [Header("Dynamic Button Setup")]
    public GameObject answerButtonTemplate;
    public Transform answerButtonParent;

    [Header("Quiz Data References")]
    public QuizData watPhnomQuiz;
    public QuizData independenceMonumentQuiz;

    // State Tracking
    private QuizData currentQuiz;
    private int currentQuestionIndex = 0;

    void Start()
    {
        // Ensure the quiz panel is hidden when the scene starts
        quizPanel.SetActive(false);
    }

    public void StartQuiz(QuizData quizData)
    {
        if (GameProgress.IsBadgeCollected(quizData.landmarkID))
        {
            Debug.Log($"Badge already collected for {quizData.landmarkName}.");
            return;
        }

        currentQuiz = quizData;
        currentQuestionIndex = 0;
        quizPanel.SetActive(true);

        // --- CRITICAL PROTECTION: Ensure CanvasGroup allows interaction ---
        if (quizPanelCanvasGroup != null)
        {
            quizPanelCanvasGroup.alpha = 1f;
            quizPanelCanvasGroup.interactable = true;
            quizPanelCanvasGroup.blocksRaycasts = true;
        }

        RenderQuestion();
    }

    private void RenderQuestion()
    {
        // Re-enable interaction at the start of rendering a new question
        if (quizPanelCanvasGroup != null)
        {
            quizPanelCanvasGroup.interactable = true;
        }

        QuestionItem currentItem = currentQuiz.questionsInQuiz[currentQuestionIndex];

        // Update UI Text
        questionTextUI.text = currentItem.questionText;
        if (quizProgressText != null)
        {
            quizProgressText.text = $"Question {currentQuestionIndex + 1} of {currentQuiz.questionsInQuiz.Count}";
        }

        // Clean up old buttons efficiently
        foreach (var child in answerButtonParent.Cast<Transform>().ToList())
        {
            Destroy(child.gameObject);
        }

        List<string> shuffledOptions = currentItem.allAnswerOptions.ToList();
        Shuffle(shuffledOptions);

        for (int i = 0; i < shuffledOptions.Count; i++)
        {
            string option = shuffledOptions[i];

            // 1. Create and activate the new button instance
            GameObject newButtonGO = Instantiate(answerButtonTemplate, answerButtonParent);
            newButtonGO.SetActive(true);

            // --- CRITICAL FIX: Explicitly re-enable components on the clone ---
            // This addresses the issue where Image/Button were unchecked at runtime.
            Button buttonComp = newButtonGO.GetComponent<Button>();
            Image imageComp = newButtonGO.GetComponent<Image>();

            if (buttonComp != null) buttonComp.enabled = true;
            if (imageComp != null) imageComp.enabled = true;
            // -----------------------------------------------------------------

            // 2. Get the button's Text component (retaining your original method)
            TextMeshProUGUI buttonText = newButtonGO.GetComponentInChildren<TextMeshProUGUI>(true); // 'true' includes inactive children

            if (buttonText != null)
            {
                buttonText.text = option;
                // Use a guaranteed visible color for debugging
                buttonText.color = Color.magenta;
                Debug.Log($"Setting button text to: {option}");
            }
            else
            {
                Debug.LogError("FATAL ERROR: TextMeshProUGUI component not found on button or its children.");
            }

            // 3. Assign the click listener
            if (buttonComp != null)
            {
                buttonComp.onClick.RemoveAllListeners();
                buttonComp.onClick.AddListener(() => CheckAnswer(option));
            }
        }
    }

    public void CheckAnswer(string selectedAnswer)
    {
        // Prevent double-clicking by disabling interaction immediately
        if (quizPanelCanvasGroup != null)
        {
            quizPanelCanvasGroup.interactable = false;
        }

        QuestionItem currentItem = currentQuiz.questionsInQuiz[currentQuestionIndex];

        if (selectedAnswer == currentItem.correctAnswer)
        {
            currentQuestionIndex++;
            if (currentQuestionIndex < currentQuiz.questionsInQuiz.Count)
            {
                // Wait briefly before rendering next question 
                Invoke("RenderQuestion", 0.5f);
            }
            else
            {
                QuizCompleteSuccess();
            }
        }
        else
        {
            QuizCompleteFailure();
        }
    }

    private void QuizCompleteSuccess()
    {
        if (quizPanelCanvasGroup != null)
        {
            quizPanelCanvasGroup.interactable = true;
        }
        quizPanel.SetActive(false);
        GameProgress.SetBadgeCollected(currentQuiz.landmarkID);
    }

    private void QuizCompleteFailure()
    {
        if (quizPanelCanvasGroup != null)
        {
            quizPanelCanvasGroup.interactable = true;
        }
        quizPanel.SetActive(false);
        currentQuestionIndex = 0;
        currentQuiz = null;
    }

    private void Shuffle<T>(List<T> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int rnd = Random.Range(0, i + 1);
            T temp = list[i];
            list[i] = list[rnd];
            list[rnd] = temp;
        }
    }
}