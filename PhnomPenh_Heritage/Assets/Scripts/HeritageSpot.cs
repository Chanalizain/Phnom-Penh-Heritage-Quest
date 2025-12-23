using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpot", menuName = "Quiz/HeritageSpot")]
public class HeritageSpot : ScriptableObject
{
    public string spotName;
    public List<QuestionAndAnswers> questions;

    // This MUST be outside all functions
    public static HeritageSpot selectedSpot;
}
