using System;

class Calculator {
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            double num1 = 0, num2 = 0, result = 0;
            char op = '+'; // Safe initial value
            bool validInput;

            // Get first number
            do {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Enter the first number: ");
                Console.ResetColor();

                string input = Console.ReadLine() ?? "";
                validInput = double.TryParse(input, out num1);

                if (!validInput) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a valid number.");
                    Console.ResetColor();
                }
            } while (!validInput);

            // Get second number
            do {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Enter the second number: ");
                Console.ResetColor();

                string input = Console.ReadLine() ?? "";
                validInput = double.TryParse(input, out num2);

                if (!validInput) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a valid number.");
                    Console.ResetColor();
                }
            } while (!validInput);

            // Get operator
            do {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter an operator (+, -, *, /): ");
                Console.ResetColor();

                string input = Console.ReadLine() ?? "";
                if (!string.IsNullOrEmpty(input) && "+-*/".Contains(input)) {
                    op = input[0];
                    validInput = true;
                } else {
                    validInput = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Please enter a valid operator.");
                    Console.ResetColor();
                }
            } while (!validInput);

            // Calculate
            switch (op) {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: division by zero");
                        Console.ResetColor();
                        continue; // go to next iteration
                    }
                    result = num1 / num2;
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
            Console.ResetColor();

            // Ask to continue or exit
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("Do you want to calculate again? (y/n): ");
            Console.ResetColor();

            string choice = (Console.ReadLine() ?? "").ToLower();
            if (choice == "n") {
                keepRunning = false;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Goodbye! 👋");
                Console.ResetColor();
            }
        }
    }
}
