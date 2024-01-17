using System;
using System.CodeDom.Compiler;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number?: ");
        // string stringNumber = Console.ReadLine();
        // int number = int.Parse(stringNumber);

        // Generate a random number.
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        // Define the guess to start the loop.
        int guess = -1;

        // Start the loop that goes while the guess is not
        // the same as the random number.
        while (guess != number)
        {
            Console.Write("What is your guess?: ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            // If the guess is smaller than the number, print Higher.
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            // If the guess is bigger than the number, print lower.
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        
        }

        // Once the loop is exited when the user's guess matches
        // the number, print You guessed it!
        Console.WriteLine("You guessed it!");
    }
}