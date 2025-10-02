using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello! Welcome to the Number Guessing Game!");
        Console.ResetColor();

        bool playAgain = true;

        while (playAgain)
        {
            int maxNumber = 100; // default Medium
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose difficulty (Easy, Medium, Hard): ");
            Console.ResetColor();
            string difficulty = Console.ReadLine().ToLower();

            if (difficulty == "easy") maxNumber = 50;
            else if (difficulty == "hard") maxNumber = 200;
            else maxNumber = 100;

            Random random = new Random();
            int targetNumber = random.Next(1, maxNumber + 1);
            int guess = 0;
            int attempts = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nI have picked a number between 1 and {maxNumber}. Can you guess it?");
            Console.ResetColor();

            while (guess != targetNumber)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your guess: ");
                Console.ResetColor();
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    attempts++;
                    if (guess < targetNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("My number is higher.");
                        Console.ResetColor();
                    }
                    else if (guess > targetNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("My number is lower.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"\nCongratulations! The number was {targetNumber}. You guessed it in {attempts} attempts.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please enter a valid number.");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDo you want to play again? (Y/N): ");
            Console.ResetColor();
            string answer = Console.ReadLine().ToUpper();
            playAgain = (answer == "Y");
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nThanks for playing! Goodbye.");
        Console.ResetColor();
    }
}
