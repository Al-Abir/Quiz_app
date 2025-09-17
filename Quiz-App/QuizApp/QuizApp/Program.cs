using System;

namespace QuizApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Germany?",
                    new string[] { "Paris", "Berlin", "London", "Madrid" },
                    1
                ),
                new Question(
                    "Which planet is known as the Red Planet?",
                    new string[] { "Earth", "Mars", "Jupiter", "Saturn" },
                    1
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
        }
    }
}
