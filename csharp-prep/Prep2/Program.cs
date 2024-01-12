using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask user for grade percentage.
        Console.Write("Please enter your grade percentage: ");
        string grade = Console.ReadLine();
        int gradePercent = int.Parse(grade);

        string letter = "";

        //Determine grade letter for user's percentage.
        if (gradePercent >= 90)
        {
            letter = "A";
            // Console.WriteLine($"Your grade is {letter}.");
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
            // Console.WriteLine($"Your grade is {letter}.");
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
            // Console.WriteLine($"Your grade is {letter}.");
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
            // Console.WriteLine($"Your grade is {letter}.");
        }
        else
        {
            letter = "F";
            // Console.WriteLine($"Your grade is {letter}.");
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("You passed.");

        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time!");
        }
    }
}