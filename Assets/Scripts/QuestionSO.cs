using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    // allow us to control the size of the box in the inspector
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";
    // Answers options available to select
    [SerializeField] string[] answers = new string[4];
    // The correct answer index based on element position of answers array
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
}