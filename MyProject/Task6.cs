using System;

class Student
{
    // Properties (Step 1)
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    // Method to display student information (Step 2)
    public void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Grade: {Grade}");
    }

    // Method to check if student passed (Step 2)
    public bool IsPassed()
    {
        return Grade >= 75;
    }
}

class Task6
{
    static void Main(string[] args)
    {
        // Step 3 & 4: Create object and set sample values
        Student student = new Student
        {
            Name = "Marco",
            Age = 20,
            Grade = 85.5
        };

        // Step 5: Call the methods
        student.DisplayInfo();

        string status = student.IsPassed() ? "Passed" : "Failed";
        Console.WriteLine($"Status: {status}");

        // Optional: Pause to see output
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}