using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Ask user for information to create a new scripture and reference object.
        Console.Clear();
        Console.Write("Please enter the book name: ");
        string bookName = Console.ReadLine();
        Console.Write("Please enter the chapter number: ");
        string chapterNum = Console.ReadLine();
        Console.Write("Please enter the start verse number: ");
        string startVerseNum = Console.ReadLine();
        Console.Write("Please enter the end verse number (if blank hit enter): ");
        string endVerseNum = Console.ReadLine();

        //Ask user for information to create all of the word objects.
        Console.Write("Please enter the text of the scripture: ");
        string verseQuote = Console.ReadLine();

        //Create the scripture and reference objects.
        Scripture userScripture = new Scripture();
        Reference userReference = new Reference(bookName, chapterNum, startVerseNum, endVerseNum);

        //Set the reference of the scripture object.
        userScripture.SetReference(userReference.CreateReference());
    
        //Iterate through each word in the verseQuote string.
        foreach (string word in verseQuote.Split(" "))
        {
            //Create a word object and add the word to the word-list in the scripture object.
            Word newWord = new Word(word);
            userScripture.AddWordToList(newWord);
        }

        //Create loop systemt for user to practice memorizing the scripture.
        string userChoice = "";

        while (userChoice.ToLower() != "quit")
        {
            //Clear the console and display the reference and verse.
            Console.Clear();
            userReference.DisplayReference();
            userScripture.DisplayText();
        
            //Prompt user to hide a random word or quit.
            Console.Write("Press enter to hide a random word or type 'quit' to quit: ");
            if (userScripture.CheckIfAllHidden() == "quit")
            {
                //Quit the loop.
                userChoice = "quit";
            }
            else
            {
                //Hide a random word.
                userChoice = Console.ReadLine();
                userScripture.HideRandomWords();
            }
        }

        //Display end program message.
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Thanks for using the Scripture Memorizer!");

    }   
}