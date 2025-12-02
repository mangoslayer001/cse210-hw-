using System;

class Program
{
    static void Main(string[] args)
    {
        // ----- Test base Assignment -----
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        // Expected:
        // Samuel Bennett - Multiplication

        // ----- Test MathAssignment -----
        MathAssignment m1 = new MathAssignment(
            "Roberto Rodriguez",
            "Fractions",
            "7.3",
            "8-19"
        );

        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine();

        // Expected:
        // Roberto Rodriguez - Fractions
        // Section 7.3 Problems 8-19

        // ----- Test WritingAssignment -----
        WritingAssignment w1 = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );

        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
        Console.WriteLine();

        // Expected:
        // Mary Waters - European History
        // The Causes of World War II by Mary Waters
    }
}
