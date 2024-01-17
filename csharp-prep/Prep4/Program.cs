using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Display beginning prompt.
        Console.WriteLine("Please enter a series of numbers to be stored on a list. ");

        // Define the user number entry to start the loop, and define an empty list of numbers.
        int userNumber = -1;
        List<int> numbers = new List<int>();

        // While the user has not typed 0, keep asking the user to enter another number and
        // then append it to the numbers list if it is not 0.
        while (userNumber != 0)
        {

            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

        
        // Compute the sum and largest number.
        int sum = 0;
        int largestNumber = -1000000;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        // Compute the average. 
        float average = ((float)sum) / (numbers.Count);

        // Display results.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}