using System;

namespace Maximum_and_Minimum_Digit
{
    public class Program
    {
        private static int MaxDigit(int number)
        {
            int max = int.MinValue;
            number = Math.Abs(number); 

            while (number > 0)
            {
                int digit = number % 10;
                if (digit > max)
                    max = digit;
                number /= 10;
            }
            return max;
        }

        // Find the minimum digit
        private static int MinDigit(int number)
        {
            int min = int.MaxValue;
            number = Math.Abs(number); 

            while (number > 0)
            {
                int digit = number % 10;
                if (digit < min)
                    min = digit;
                number /= 10;
            }
            return min;
        }

        public static void Main(string[] args)
        {
            // Welcome message
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("🌟 Welcome to the Maximum and Minimum Digits App! 🌟");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nPlease enter a number to find its max and min digits (or type 'exit' to quit):");
                Console.ResetColor();

                string input = Console.ReadLine() ?? "";
                if (input.ToLower() == "exit")
                    break;

                if (int.TryParse(input, out int number))
                {
                    int max = MaxDigit(number);
                    int min = MinDigit(number);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n✨ Maximum digit: {max} ✨");
                    Console.WriteLine($"✨ Minimum digit: {min} ✨");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n❌ Invalid input! Please enter a valid integer.");
                    Console.ResetColor();
                }
            }

            // Goodbye message
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nThank you for using the Maximum and Minimum Digits App! Goodbye! 💖");
            Console.ResetColor();
        }
    }
}
