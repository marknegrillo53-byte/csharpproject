using System;

class ArithmeticCalculator
{
    static void Main(string[] args)
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            Console.Clear(); // Optional: cleans screen for better readability
            Console.WriteLine("Arithmetic Calculator");
            Console.WriteLine("---------------------");
            Console.WriteLine("Press any of the following keys to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.Write("\nEnter your choice (1-4): ");

            string choiceInput = Console.ReadLine();
            if (!int.TryParse(choiceInput, out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                Console.WriteLine("\nPress any key to try again...");
                Console.ReadKey();
                continue;
            }

            // Get the two numbers
            double num1 = GetNumber("Enter Value 1: ");
            double num2 = GetNumber("Enter Value 2: ");

            double result = 0;
            string operationSymbol = "";

            // Use switch to select operation
            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    operationSymbol = "+";
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    operationSymbol = "-";
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    operationSymbol = "×";  // or "*" if × is not preferred
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                        goto AskContinue;
                    }
                    result = Divide(num1, num2);
                    operationSymbol = "÷";  // or "/" if ÷ is not preferred
                    break;
            }

            // Display result in requested format
            Console.WriteLine($"\n{num1} {operationSymbol} {num2} = {result}");

        AskContinue:
            Console.Write("\nDo you want to continue again (Y/N)? ");
            string response = Console.ReadLine()?.Trim().ToUpper();

            if (response != "Y")
            {
                continueCalculating = false;
                Console.WriteLine("Thank you for using the calculator. Goodbye!");
            }
        }
    }

    // Separate methods for each operation
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }

    // Helper method to safely read a number
    static double GetNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                return number;
            }
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}