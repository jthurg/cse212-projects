using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

//This Mindfulness Program exceeds requirements by adding an
//additional Gratitude Activity where the user can ponder and
//record things from the day that they are grateful for.

//Main Program.
class Program
{
    static void Main(string[] args)
    {
        //Clear Console.
        Console.Clear();

        //Display program start message.
        Console.WriteLine("Welcome to the Mindfulness Program!");

        //Define menu string.
        string menuText = "Menu Options:\n" + 
        "   1. Start Breathing Activity\n" + 
        "   2. Start Reflection Activity\n" + 
        "   3. Start Listing Activity\n" + 
        "   4. Start Gratitude Activity\n" + 
        "   5. Quit\n" + 
        "Select a choice from the menu: ";

        //Start menu loop.
        string userChoice = "0";
        while (userChoice != "5")
        {
            //Display menu.
            Console.Write(menuText);
            userChoice = Console.ReadLine();

            //Define empty string for activity name and description.
            string activityName = "";
            string activityDescription = "";

            if (userChoice == "1")
            {
                //Create Breathing Activity object.
                activityName = "Breathing";
                activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathingActivity = new BreathingActivity(activityName, activityDescription);

                //Run BreathingActivity.
                breathingActivity.RunActivity();
            }

            else if (userChoice == "2")
            {
                //Create Reflection Activity object.
                activityName = "Reflection";
                activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectionActivity reflectionActivity = new ReflectionActivity(activityName, activityDescription);
                
                //Run ReflectionActivity.
                reflectionActivity.RunActivity();
            }

            else if (userChoice == "3")
            {
                //CreateListing Activity object.
                activityName = "Listing";
                activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";                
                ListingActivity listingActivity = new ListingActivity(activityName, activityDescription);

                //Run ListingActivity object.
                listingActivity.RunActivity();
            }
            else if (userChoice == "4")
            {
                //Create GratitudeActivity object.
                activityName = "Gratitude";
                activityDescription = "This activity will have you take a moment to be grateful for all the things in your life today. This will help you feel better about yourself and show God that you are grateful.";
                GratitudeActivity gratitudeActivity = new GratitudeActivity(activityName, activityDescription);

                //Run GratitudeActivity.
                gratitudeActivity.RunActivity();
            }

            else if (userChoice == "5")
            {
                //Quit program.
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                Console.WriteLine();
            }

            else
            {
                //Display error message.
                Console.WriteLine("That is an invalid choice. Please enter a number 1-5.");
            }
        }
    }
}