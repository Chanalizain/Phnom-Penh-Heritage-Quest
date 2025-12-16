//QuizData.cs (Main Scriptable Object)
//it holds the entire list of questions for a specific landmark's quiz challenge.

using UnityEngine;
using System.Collections.Generic;//for using list

// This attribute allows to create a new asset: Create -> Quiz -> Landmark Quiz Set
[CreateAssetMenu(fileName = "New Landmark Quiz", menuName = "Quiz/Landmark Quiz Set")]
public class QuizData : ScriptableObject
{
    [Header("Landmark Details")]
    [Tooltip("Unique ID for progress tracking (e.g., 1 for Wat Phnom)")]
    public int landmarkID;

    public string landmarkName;

    public Sprite badgeIcon;

    [Header("Questions for this Quiz (Must complete all to earn badge)")]
    [Tooltip("Add the required number of questions here (e.g., set list size to 3)")]
    // The main list that holds all sequential questions
    public List<QuestionItem> questionsInQuiz;
}

