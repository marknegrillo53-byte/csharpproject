using System;

class StudentReportCard
{
    static void Main(string[] args)
    {
        Console.WriteLine("Student Report Card Generator");
        Console.WriteLine("============================\n");

        // Step 1: Get total number of students
        Console.Write("Enter Total Students: ");
        if (!int.TryParse(Console.ReadLine(), out int totalStudents) || totalStudents <= 0)
        {
            Console.WriteLine("Invalid number of students! Exiting...");
            return;
        }

        // Multi-dimensional jagged array:
        // [studentIndex, 0] = Name (string)
        // [studentIndex, 1] = English
        // [studentIndex, 2] = Math
        // [studentIndex, 3] = Computer
        // [studentIndex, 4] = Total (calculated later)
        object[][] students = new object[totalStudents][];

        // Input loop for each student
        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine($"\n*********************************************");
            Console.Write($"Enter Student Name: ");
            string name = Console.ReadLine()?.Trim() ?? "Unknown";

            int english = GetValidMark("Enter English Marks (Out Of 100): ");
            int math    = GetValidMark("Enter Math Marks (Out Of 100): ");
            int computer = GetValidMark("Enter Computer Marks (Out Of 100): ");

            int total = english + math + computer;

            // Store data
            students[i] = new object[] { name, english, math, computer, total };
        }

        // Step 2: Sort students by total marks (descending)
        Array.Sort(students, (a, b) => 
            ((int)b[4]).CompareTo((int)a[4])); // descending order

        // Step 3: Display Report Card
        Console.WriteLine("\n****************Report Card*******************");
        Console.WriteLine("****************************************");

        for (int rank = 0; rank < students.Length; rank++)
        {
            string name     = (string)students[rank][0];
            int total       = (int)students[rank][4];
            int position    = rank + 1; // 1-based rank

            Console.WriteLine($"Student Name: {name}, Position: {position}, Total: {total}/300");
            Console.WriteLine("****************************************");
        }

        Console.WriteLine("\nThank you for using the Student Report Card Generator!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Helper method to get valid marks (0-100)
    static int GetValidMark(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int mark) && mark >= 0 && mark <= 100)
            {
                return mark;
            }

            Console.WriteLine("Invalid mark! Please enter a number between 0 and 100.");
        }
    }
}