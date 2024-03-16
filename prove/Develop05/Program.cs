using System;
using System.Reflection.Metadata;
using System.IO;

//To exceed the requirements, I have made it so that
//the user can achieve badges based on their total points.
//I have also made it so they know how many points they
//have left until they reach the next badge status.

class Program
{
    static void Main(string[] args)
    {

        //Define goal list.
        List<Goal> goalList = new List<Goal>();

        //Define menu variables.
        int totalPoints = 0;
        string menuText = "Menu Options:\n" +
            "   1. Create New Goal\n" +
            "   2. List Goals\n" +
            "   3. Save Goals\n" +
            "   4. Load Goals\n" +
            "   5. Record Event\n" +
            "   6. Quit\n" +
            "Select a choice from the menu: ";

        //Spacing.
        Console.WriteLine();

        //Start menu loop.
        string userChoice = "0";
        while (userChoice != "6")
        {
            //Check and set badge status.
            string badge = "";
            string nextBadge = "";
            int nextBadgePoints = 0;
            if (totalPoints < 400)
            {
                badge = "Beginner";
                nextBadge = "Bronze";
                nextBadgePoints = 400;
            }

            else if (totalPoints >= 400 && totalPoints < 700)
            {
                badge = "Bronze";
                nextBadge = "Silver";
                nextBadgePoints = 700;
            }

            else if (totalPoints >= 700 && totalPoints < 1000)
            {
                badge = "Silver";
                nextBadge = "Gold";
                nextBadgePoints = 1000;
            }

            else
            {
                badge = "Gold";
                nextBadge = "";
            }

            //Display total points and badge status.
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine("Your Badge Status: " + badge);
            if (badge != "Gold")
            {
                Console.WriteLine($"You need to earn {nextBadgePoints - totalPoints} more points to get the {nextBadge} badge.");
            }

            else
            {
                Console.WriteLine("You have achieved the highest badge. Keep it up!");
            }

            //Spacing.
            Console.WriteLine();

            //Display menu and ask for user input.
            Console.Write(menuText);
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string goalTypesMenu = "The types of Goals are:\n" +
                    "   1. Simple Goal\n" +
                    "   2. Eternal Goal\n" +
                    "   3. Checklist Goal\n" +
                    "   4. Back\n" +
                    "Which type of goal would you like to create? ";
                
                //Define empty goal variable to start goal type menu loop.
                string goalChoice = "0";

                //Start goal type menu loop.
                while (goalChoice != "4")
                {
                    //Display goal types menu and ask for user input.
                    Console.Write(goalTypesMenu);
                    goalChoice = Console.ReadLine();

                    if (goalChoice == "1")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal("", "", 0, false);
                        simpleGoal.SetName();
                        simpleGoal.SetDescription();
                        simpleGoal.SetPointValue();
                        goalList.Add(simpleGoal);
                        goalChoice = "4";
                    }

                    else if (goalChoice == "2")
                    {
                        EternalGoal eternalGoal = new EternalGoal("", "", 0);
                        eternalGoal.SetName();
                        eternalGoal.SetDescription();
                        eternalGoal.SetPointValue();
                        goalList.Add(eternalGoal);
                        goalChoice = "4";

                    }

                    else if (goalChoice == "3")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal("", "", 0, false, 0, 0,0);
                        checklistGoal.SetName();
                        checklistGoal.SetDescription();
                        checklistGoal.SetPointValue();
                        checklistGoal.SetTimesNeedAccomplished();
                        checklistGoal.SetBonusPoints();
                        goalList.Add(checklistGoal);
                        goalChoice = "4";
                    }

                    else if (goalChoice == "4")
                    {
                        //Quit goal type menu.
                    }

                    else 
                    {
                        Console.WriteLine("That is not a valid choice. Please enter a number 1-4.");
                    }
                }
            //Spacing.
            Console.WriteLine();
            }
            
            else if (userChoice == "2")
            {
                int count = 0;
                //Display list of goals.
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in goalList)
                {
                    count += 1;
                    if (goal.GetIsComplete() == false)
                    {
                        Console.WriteLine($"{count}. [ ] {goal.GetGoalSummary()}");
                    }

                    else
                    {
                        Console.WriteLine($"{count}. [X] {goal.GetGoalSummary()}");
                    }
                }
                //Spacing.
                Console.WriteLine();
            }

            else if (userChoice == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                //Clear the file first if it already exists.
                using(StreamWriter outputFile = new StreamWriter(filename))
                {
                    for (int i = 0; i<100; i++)
                    {
                        outputFile.WriteLine("");
                    }
                }

                //Write the total points and saved goals to the text file.
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    string pointsString = $"Points,{totalPoints}";
                    outputFile.WriteLine(pointsString);
                    foreach (Goal goal in goalList)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                }
                //Spacing.
                Console.WriteLine();
            }

            else if (userChoice == "4")
            {
                //Ask for filename.
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                
                //Clear the goal list before ammending the goals from the loaded text file.
                goalList.Clear();

                //Read the text file.
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    
                    //If line is a single number, then it is the total points.
                    if (parts[0] == "Points")
                    {
                        totalPoints = int.Parse(parts[1]);
                    }

                    //If line is not a single number, evaluate its entries to create a new goal for each line.
                    else
                    {
                        //Split the line into smaller parts.
                        string[] baseParts = line.Split(":");
                        string type = baseParts[0];

                        //Split the smaller parts into respective variables.
                        string[] smallerParts = baseParts[1].Split(",");
                        string name = smallerParts[0];
                        string description = smallerParts[1];
                        int pointValue = int.Parse(smallerParts[3]);
                        string isComplete = smallerParts[2];

                        //Define a completion bool to help with converting the string fromt text file into a boolean.
                        bool completion = false;
                        if (isComplete.ToLower() == "true")
                        {
                            completion = true;
                        }

                        else
                        {
                            completion = false;
                        }

                        //If type is SimpleGoal, create new SimpleGoal and add to gaols list.
                        if (type == "SimpleGoal")
                        {
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, pointValue, completion);
                            goalList.Add(simpleGoal);
                        }

                        //If type is EternalGoal, create new eternalGoal and add to goals list.
                        else if (type == "EternalGoal")
                        {
                            EternalGoal eternalGoal = new EternalGoal(name, description, pointValue);
                            goalList.Add(eternalGoal);
                        }

                        //If type is ChecklistGoal, create new ChecklistGoal and add to goals list.
                        else if (type == "ChecklistGoal")
                        {
                            int bonusPoints = int.Parse(smallerParts[4]);
                            int timesHaveAccomplished = int.Parse(smallerParts[5]);
                            int timesNeedAccomplished = int.Parse(smallerParts[6]);
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, pointValue, completion, timesHaveAccomplished, timesNeedAccomplished, bonusPoints);
                            goalList.Add(checklistGoal);
                        }
                    }
                }
            }

            //Record an event for a specific goal.
            else if (userChoice == "5")
            {
                //Define a goalNumber variable to help with the while loop.
                string goalNumber = "0";
                while (goalNumber.ToLower() != "q")
                {
                    //Display list of goals.
                    Console.WriteLine("The goals are: ");
                    int goalCount = 0;
                    foreach (Goal goal in goalList)
                    {
                        goalCount += 1;
                        Console.WriteLine($"{goalCount}. {goal.GetName()}");
                    }

                    //Ask user to select a goal.
                    Console.Write("What goal did you accomplish? (Type 'q' go back): ");
                    goalNumber = Console.ReadLine();

                    if (goalNumber == "q")
                    {
                        //Quit the loop.
                    }

                    //If goal is valid, record it and display points earned and new total.
                    else if (int.Parse(goalNumber) > 0 && int.Parse(goalNumber) <= goalList.Count())
                    {
                        goalList[int.Parse(goalNumber) - 1].RecordEvent();
                        int earnedPoints = goalList[int.Parse(goalNumber) - 1].IsComplete();
                        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
                        totalPoints += earnedPoints;
                        Console.WriteLine($"You now have {totalPoints} points.");
                        
                        //Spacing.
                        Console.WriteLine();

                        //Quit the loop.
                        goalNumber = "q";

                    }

                    //If goal is not valid, display error message and ask user to try again.
                    else
                    {
                        Console.WriteLine($"Invalid choice. Please enter a number 1-{goalList.Count()}.");
                    }
                }
            }

            //Quit the program.
            else if (userChoice == "6")
            {
                //Quit the program.
            }

            //Display an error message if user input is invalid.
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number 1-6.");
            }
        }

        //Display end program thank you message.
        Console.WriteLine();
        Console.WriteLine("Thank you for using the Goals Program! Goodbye!");
    }
}