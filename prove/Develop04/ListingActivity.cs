public class ListingActivity : Activity
{
    //Define member variables.
    private List<string> _promptList = new List<string>{"Who are people that you appreciate?", 
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
    private string _randomPrompt = "";

    //Define constructor.
    public ListingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
    }

    //Define methods.
    public void GetRandomPrompt()
    {
        //Select a random prompt and save it in the _randomPrompt variable.
        Random random = new Random();
        int promptNum = random.Next(0, _promptList.Count);
        _randomPrompt = _promptList[promptNum];
    }

    public void DisplayRandomPrompt()
    {
        //Display the random prompt.
        Console.Write(_randomPrompt);
    }

    public void RunActivity()
    {
        //Display activity instructions.
        DisplayStartMessage();
        GetAndSetTimeDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseAndShowAnimation(5);
        GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.Write("--- ");
        DisplayRandomPrompt();
        Console.WriteLine(" ---");
        Console.Write("You may begin in: ");
        PauseAndShowTimer(5);
        Console.WriteLine();

        //Start the time loop.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeDuration);
        int responseCount = 0;
        while (DateTime.Now < endTime)
        {
            //Allow user to list responses.
            Console.Write("> ");
            Console.ReadLine();
            responseCount += 1;
        }
        Console.WriteLine($"You listed {responseCount} items!");

        //Display end message.
        Console.WriteLine();
        DisplayEndMessage();
    }
}