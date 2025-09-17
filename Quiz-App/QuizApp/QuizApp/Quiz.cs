using System;

namespace QuizApp
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        public void StartQuiz()
        {
            Console.WriteLine("=== Welcome to the Quiz ===\n");
            int questionNumber = 1;
            int score = 0;

            foreach (Question question in questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);

                int userChoice = GetUserChoice();

                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("✅ Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"❌ Wrong! The correct answer is: {question.Answers[question.CorrectIndex]}\n");
                }
            }

            Console.WriteLine($"=== Quiz Finished ===");
            Console.WriteLine($"Your Score: {score}/{questions.Length}");
        }

        private void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.WriteLine($" {i + 1}. {question.Answers[i]}");
            }
        }

        private int GetUserChoice()
        {
            Console.Write("Your Answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;

            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                input = Console.ReadLine();
            }

            return choice - 1; // index 0 থেকে শুরু
        }
    }
}
