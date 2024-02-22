using System;

class Program
{
    static void Main(string[] args)
    {
        //Create assignment object.
        Assignment assignment1 = new Assignment("Jordan", "CSE 210");
        Console.WriteLine(assignment1.GetSummary());

        //Create mathassignment object.
        MathAssignment mathAssignment1 = new MathAssignment("Jordan", "Fractions", "8.6", "9-13");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        //Create writingassignment object.
        WritingAssignment writingAssignment1 = new WritingAssignment("Jordan", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}