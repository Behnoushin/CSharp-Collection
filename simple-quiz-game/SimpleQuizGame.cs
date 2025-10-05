using System;
using System.Collections.Generic;

namespace SimpleQuizGame
{
    class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }
        public int CorrectOption { get; set; }

        public Question(string text, string[] options, int correctOption)
        {
            Text = text;
            Options = options;
            CorrectOption = correctOption;
        }
    }

    class QuizGame
    {
        private List<Question> questions = new List<Question>();
        private int score = 0;

        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Simple Quiz Game!\n");
            Console.ResetColor();

            for (int i = 0; i < questions.Count; i++)
            {
                Question q = questions[i];
                Console.WriteLine($"{i + 1}. {q.Text}");
                for (int j = 0; j < q.Options.Length; j++)
                {
                    Console.WriteLine($"  {j + 1}. {q.Options[j]}");
                }

                Console.Write("Your answer (option number): ");
                string input = Console.ReadLine();
                int answer;
                if (int.TryParse(input, out answer) && answer - 1 == q.CorrectOption)
                {
                    Console.WriteLine("✅ Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"❌ Wrong! Correct answer: {q.Options[q.CorrectOption]}\n");
                }
            }

            Console.WriteLine($"Game Over! Your score: {score}/{questions.Count} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QuizGame game = new QuizGame();

            game.AddQuestion(new Question(
                "What is Python?",
                new string[] { "A bird", "A programming language", "A car", "A city" },
                1
            ));

            game.AddQuestion(new Question(
                "2 + 2 equals?",
                new string[] { "3", "4", "5", "6" },
                1
            ));

            game.AddQuestion(new Question(
                "What is the color of the sky on a clear day?",
                new string[] { "Green", "Blue", "Red", "Yellow" },
                1
            ));

            game.Start();
        }
    }
}
