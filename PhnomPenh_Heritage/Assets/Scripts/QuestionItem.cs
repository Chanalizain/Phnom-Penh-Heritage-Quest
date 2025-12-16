//QuestionItem(Inner Data Structure)
//This class defines the structure for a single question within the quiz.
//It must be marked [System.Serializable] so Unity can save its contents into the main asset file.

using UnityEngine;

[System.Serializable]
public class QuestionItem
{
    [Header("Question Content")]
    public string questionText;
    public string correctAnswer;

    [Tooltip("Enter ALL options here, including the correct one.")]// text to display when hovering over 
    public string[] allAnswerOptions;
}