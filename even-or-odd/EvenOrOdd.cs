using System;

class Program
{
    static void Main(string[] args)
    {
        // Flag to keep the program running until the user decides to exit
        bool keepRunning = true;

        // Display the program title
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Odd Or Even Checker 🌟");
        Console.ResetColor();

        // Main loop: keep asking user for numbers until they choose to exit
        while (keepRunning)
        {
            // Prompt user to enter a number
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPlease enter a number:");
            Console.ResetColor();

            try
            {
                // Read user input, ensure it's not null
                string input = Console.ReadLine() ?? "";
                
                // Convert input string to integer
                int number = Convert.ToInt32(input);

                // ======= Determine odd/even and zero/positive/negative =======
                string result;

                if (number == 0)
                    result = "zero (which is even)";
                else if (number % 2 == 0)
                    result = "even";
                else
                    result = "odd";

                if (number > 0)
                    result += " and positive";
                else if (number < 0)
                    result += " and negative";
                // ==================================================

                // Display the result
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n✨ {number} is {result}! ✨");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                // Handle invalid input (non-numeric)
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ Oops! That's not a valid number.");
                Console.ResetColor();
            }

            // Ask user if they want to check another number
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nDo you want to check another number? (y/n):");
            Console.ResetColor();

            // Read user choice and convert to lowercase
            string choice = (Console.ReadLine() ?? "").ToLower();
            if (choice == "n")
            {
                // If user chooses 'n', stop the loop and exit
                keepRunning = false;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nThank you for using Odd Or Even Checker! 💖");
                Console.ResetColor();
            }
        }
    }
}
