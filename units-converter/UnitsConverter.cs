using System;

public class UnitConverter
{
    private double unit;

    public UnitConverter(double unit)
    {
        this.unit = unit;
    }

    // Meters
    public double MetersToFeet() => unit * 3.28084;
    public double MetersToCentimeters() => unit * 100;
    public double MetersToInches() => unit * 39.3701;
    public double MetersToKilometers() => unit / 1000;
    public double MetersToYards() => unit * 1.09361;

    // Feet
    public double FeetToMeters() => unit * 0.3048;
    public double FeetToInches() => unit * 12;

    // Inches
    public double InchesToCentimeters() => unit * 2.54;

    // Centimeters
    public double CentimetersToMeters() => unit / 100;
}

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("🌟 Welcome to the Ultimate Unit Converter! 🌟");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nChoose conversion type:");
            Console.WriteLine("1. Meters to Feet");
            Console.WriteLine("2. Meters to Inches");
            Console.WriteLine("3. Meters to Centimeters");
            Console.WriteLine("4. Meters to Kilometers");
            Console.WriteLine("5. Meters to Yards");
            Console.WriteLine("6. Feet to Meters");
            Console.WriteLine("7. Feet to Inches");
            Console.WriteLine("8. Inches to Centimeters");
            Console.WriteLine("9. Centimeters to Meters");
            Console.WriteLine("0. Exit");
            Console.ResetColor();

            string choice = Console.ReadLine() ?? "";

            if (choice == "0") break;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter the value to convert: ");
            Console.ResetColor();

            string input = Console.ReadLine() ?? "";
            if (!double.TryParse(input, out double value))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Invalid input! Please enter a number.");
                Console.ResetColor();
                continue;
            }

            UnitConverter converter = new UnitConverter(value);
            Console.ForegroundColor = ConsoleColor.Cyan;

            switch (choice)
            {
                case "1": Console.WriteLine($"{value} meters = {converter.MetersToFeet()} feet"); break;
                case "2": Console.WriteLine($"{value} meters = {converter.MetersToInches()} inches"); break;
                case "3": Console.WriteLine($"{value} meters = {converter.MetersToCentimeters()} cm"); break;
                case "4": Console.WriteLine($"{value} meters = {converter.MetersToKilometers()} km"); break;
                case "5": Console.WriteLine($"{value} meters = {converter.MetersToYards()} yards"); break;
                case "6": Console.WriteLine($"{value} feet = {converter.FeetToMeters()} meters"); break;
                case "7": Console.WriteLine($"{value} feet = {converter.FeetToInches()} inches"); break;
                case "8": Console.WriteLine($"{value} inches = {converter.InchesToCentimeters()} cm"); break;
                case "9": Console.WriteLine($"{value} cm = {converter.CentimetersToMeters()} meters"); break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("❌ Invalid choice!"); 
                    Console.ResetColor();
                    break;
            }

            Console.ResetColor();
        }

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Thank you for using the Ultimate Unit Converter! Goodbye! 💖");
        Console.ResetColor();
    }
}
