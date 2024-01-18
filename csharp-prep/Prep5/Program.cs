using System;

class Program
{
    static void Main(string[] args)
    {
        // Display the welcome message.
        DisplayWelcome();

        //Retrieve the name of the user.
        string userName = PromptUserName();

        // Retrieve the user's favorite number.
        int userNumber = PromptUserNumber();

        //Square the user's favorite number.
        int squareNumber = SquareNumber(userNumber);

        //Display the final results.
        DisplayResult(userName, squareNumber);

    }

    static void DisplayWelcome()
    {
        //Display the welcome message.
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        //Prompt user for their name and return it as a string.
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        //Prompt user for favorite number and return it as an int.
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        //Square the user's number and return it as an int.
        int squareNumber = number * number;
        return squareNumber;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        //Convert the user's number to a string.
        string numString = squaredNumber.ToString();

        //Create a string to display the user's name and the square number from their original number. 
        string message = name + ", the square of your number is " + numString + ".";

        //Display the string created in the line above.
        Console.WriteLine(message);
    }
}
    