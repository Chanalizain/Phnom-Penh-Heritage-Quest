using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpot", menuName = "Quiz/HeritageSpot")]
public class HeritageSpot : ScriptableObject
{
    public static HeritageSpot selectedSpot;
    public string spotName;
    public string learningSceneName;
    public List<QuestionAndAnswers> questions;

}
