using System;

namespace QuizApp
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectIndex { get; set; }

        public Question(string questionText, string[] answers, int correctIndex)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectIndex = correctIndex;
        }

        public bool IsCorrectAnswer(int choice)
        {
            return CorrectIndex == choice;
        }
    }
}
