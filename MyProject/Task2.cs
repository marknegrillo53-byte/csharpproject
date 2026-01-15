using System;

class Task2
{
    static void Main(string[] args)
    {
        // Step 2: Declare and initialize the jagged array
        int[][] numberMatrix = new int[][]
        {
            new int[] { 2, 4, 6, 8, 10 },    // Row 0 - Even numbers
            new int[] { 1, 3, 5, 7, 9 }      // Row 1 - Odd numbers
        };

        Console.WriteLine("The number matrix has been initialized.");

        // Step 4: Extract the required digits according to the clues
        int digit1 = numberMatrix[1][3];    // Row 1, Index 3 → 7
        int digit2 = numberMatrix[0][0];    // Row 0, Index 0 → 2
        int digit3 = numberMatrix[1][4];    // Row 1, Index 4 → 9

        // Step 5: Combine digits into a 3-digit string (password/key)
        string finalKey = digit2.ToString() + digit1.ToString() + digit3.ToString();
        // Alternative ways you could also do it:
        // string finalKey = $"{digit2}{digit1}{digit3}";
        // string finalKey = digit2 + "" + digit1 + "" + digit3;

        // Display the result
        Console.WriteLine("\nExtracted digits:");
        Console.WriteLine($"Digit 1 (Row 1, Col 3): {digit1}");
        Console.WriteLine($"Digit 2 (Row 0, Col 0): {digit2}");
        Console.WriteLine($"Digit 3 (Row 1, Col 4): {digit3}");
        Console.WriteLine($"\nThe password / 3-digit key is: {finalKey}");
    }
}