using System;
using System.Diagnostics;

//Sources I used in this project:
//https://learn.microsoft.com/en-us/dotnet/api/system.io.file.readalllines?view=net-8.0

class Program
{
    static void Main(string[] args)
    {
        //Instantiate a new journal object.
        Journal userJournal = new Journal();

        //Instantiate a new Prompt Generator Object.
        PromptGenerator promptGenObject = new PromptGenerator();

        //Start the program menu loop.
        string userChoice = "1";
        while (userChoice != "5")
        {
            //Display program menu.
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

            //Prompt user for a menu choice.
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            Console.WriteLine($"You chose: {userChoice}");

            //Enter a switch that depends on the menu selection entry from the user.
            switch (userChoice)
            {
                case "1":
                //Write an Entry.

                    //Instantiate a new Entry object.
                    Entry entry = new Entry();

                    //Obtain date from the user's OS.
                    DateTime currentDate = DateTime.Now;
                    string dateText = currentDate.ToShortDateString();
                    entry._date = dateText;

                    //Generate a random prompt and obtain user's response to prompt.
                    promptGenObject.DisplayRandomPrompt();
                    entry._entryPrompt = promptGenObject._generatedPrompt;
                    Console.Write("> ");
                    string userTextEntry = Console.ReadLine();
                    entry._entryText = userTextEntry;

                    //Obtain user's favorite meal of the day.
                    Console.WriteLine("What was your favorite meal today?");
                    Console.Write("> ");
                    string userMeal = Console.ReadLine();
                    entry._entryMeal = userMeal;

                    //Add the Entry object to the _entries list.
                    userJournal.AddEntryToList(entry);
                    break;

                case "2":
                //Display entries.

                    //Display entries in the userJournal object.
                    userJournal.DisplayEntries();
                    break;

                case "3":
                //Load from file.

                    //Ask user for a filename and use it to load a file
                    //using the LoadFromFile method in the userJournal object.
                    Console.WriteLine("What is the filename?");
                    string loadFilename = Console.ReadLine();
                    userJournal.LoadFromFile(loadFilename);
                    break;

                case "4":
                //Save to file.

                    //Ask user for a filename and use it to save the _entries list
                    //to the file. The input file must be a csv file.
                    Console.WriteLine("What is the filename?");
                    string saveFilename = Console.ReadLine();
                    userJournal.SaveToFile(saveFilename);
                    break;

                case "5":
                //Quit the program.
                
                    //Quit the while loop since the user entered 5
                    Console.WriteLine("Thanks for your entries! The End.");
                    break;
                default:
                    //Display an error message and begin the while loop again.
                    Console.WriteLine("Error. Please enter a number 1-5.");
                    break;
            }
        }
    }
}