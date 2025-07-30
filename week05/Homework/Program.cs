using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        // Now create the derived class assignments
        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());    // From base class
        Console.WriteLine(mathAssignment1.GetHomeworkList());   // From derived class


        WritingAssignment writingAssignment1 = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World Ward II"
        );

        Console.WriteLine(writingAssignment1.GetSummary()); // From base class
        Console.WriteLine(writingAssignment1.GetWritingInfo()); //From derived class
        
    }
}