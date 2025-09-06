using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("🌡️ Welcome to the Temperature Converter! 🌡️");
        Console.ResetColor();

        // Main loop
        while (true)
        {
            // Show menu
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Convert Celsius ➡ Fahrenheit");
            Console.WriteLine("2. Convert Fahrenheit ➡ Celsius");
            Console.WriteLine("3. Exit");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("👉 Your choice: ");
            Console.ResetColor();
            string choice = Console.ReadLine();

            // Handle user choice
            switch (choice)
            {
                case "1":
                    ConvertCelsiusToFahrenheit();
                    break;
                case "2":
                    ConvertFahrenheitToCelsius();
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n💖 Thank you! Goodbye! 💖");
                    Console.ResetColor();
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ Invalid choice. Try again.");
                    Console.ResetColor();
                    break;
            }
        }
    }

    // Convert Celsius to Fahrenheit
    static void ConvertCelsiusToFahrenheit()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter temperature in Celsius: ");
        Console.ResetColor();

        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Invalid input!");
        }
        Console.ResetColor();
    }

    // Convert Fahrenheit to Celsius
    static void ConvertFahrenheitToCelsius()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Enter temperature in Fahrenheit: ");
        Console.ResetColor();

        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Invalid input!");
        }
        Console.ResetColor();
    }
}
