using System;
public class Program
{
    // Function to calculate sum of digits
    private static int SumOfDigits(int number)
    {
        int result = 0;
        number = Math.Abs(number); // Handle negative numbers

        while (number > 0)
        {
            result += number % 10;
            number /= 10;
        }
        return result;
    }

    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("🌟 Welcome to the Sum of Digits App 🌟");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPlease enter a number (or type 'exit' to quit):");
            Console.ResetColor();

            string input = Console.ReadLine() ?? "";

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int number))
            {
                int sum = SumOfDigits(number);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n✨ The sum of digits for {number} is {sum} ✨");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ Invalid input! Please enter a valid integer.");
                Console.ResetColor();
            }
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nThank you for using the Sum of Digits App! 💖");
        Console.ResetColor();
    }
}