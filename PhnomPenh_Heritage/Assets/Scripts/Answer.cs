using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public void Answered()
    {
        if (isCorrect)
        {
            quizManager.correct();
        }
        else
        {
            quizManager.wrong(); 
        }
    }
}
