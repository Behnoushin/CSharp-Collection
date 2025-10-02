using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to the Longest & Shortest Word Finder!");
        Console.ResetColor();

        bool playAgain = true;

        while (playAgain)
        {
            Console.Write("\n👉 Please enter a sentence: ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string longest = words[0];
                string shortest = words[0];

                foreach (var word in words)
                {
                    if (word.Length > longest.Length)
                        longest = word;
                    if (word.Length < shortest.Length)
                        shortest = word;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nLongest word: {longest} ({longest.Length} letters)");
                Console.WriteLine($"Shortest word: {shortest} ({shortest.Length} letters)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ No input provided!");
                Console.ResetColor();
            }

            Console.Write("\n🔁 Do you want to try again? (Y/N): ");
            string answer = Console.ReadLine().ToUpper();
            playAgain = (answer == "Y");
        }

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nThanks for using the Word Finder! Goodbye!");
        Console.ResetColor();
    }
}
