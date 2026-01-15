using System;

class Task3
{
    static void Main(string[] args)
    {
        // Declare and initialize the array
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

        // Welcome message
        Console.WriteLine("Number Search Program");
        Console.WriteLine("----------------------");
        Console.WriteLine("Available numbers: 3, 7, 12, 19, 21, 25, 30\n");

        // Ask user for input
        Console.Write("Enter a number to search for: ");

        // Read and convert user input
        if (!int.TryParse(Console.ReadLine(), out int searchNumber))
        {
            Console.WriteLine("Invalid input! Please enter a whole number.");
            return; // Exit the program if input is not a valid integer
        }

        // Variable to track if number was found
        bool found = false;
        int position = -1; // Will store the index if found

        // Loop through the array
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchNumber)
            {
                found = true;
                position = i;
                Console.WriteLine($"\nNumber found at position {position}!"); // 0-based index
                // Alternative: 1-based index (more user-friendly)
                // Console.WriteLine($"\nNumber found at position {position + 1}!");
                break; // Exit the loop immediately
            }
        }

        // Check if we went through the entire loop without finding the number
        if (!found)
        {
            Console.WriteLine("\nNumber not found in the list.");
        }

        Console.WriteLine("\nProgram finished. Press any key to exit...");
        Console.ReadKey();
    }
}