public class Activity
{
    //Define member variables.
    private string _activityName = "";
    private string _activityDescription = "";
    protected int _timeDuration = 0;

    //Define constructor.
    public Activity(string activityName, string activityDescription)
    {
        //Initialize member variables.
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    //Define methods.
    public void DisplayStartMessage()
    {
        //Display the start message.
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine();  
    }

    public void DisplayEndMessage()
    {
        //Display the end message.
        Console.WriteLine("Well done!");
        PauseAndShowAnimation(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_timeDuration.ToString()} seconds of the {_activityName} Activity.");
        PauseAndShowAnimation(3);
        Console.Clear();
    }

    public void PauseAndShowAnimation(int timeDuration)
    {
        //Define animation strings list.
        List<string> animationStrings = new List<string>{"|", "/", "-", "\\", 
        "|", "/", "-", "\\",};

        //Start time loop to create the timer animation.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeDuration);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            //Cycle through displaying the animation strings.
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(60);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

     public void PauseAndShowTimer(int timeDuration)
    {
        //Start time loop to create the timer animation.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeDuration);
        while (DateTime.Now < endTime)
        {
            //Display the timer.
            for (int i = timeDuration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public void GetAndSetTimeDuration()
    {
        //Ask user for time duration in seconds, then store it in the member variable as an integer.
        Console.Write("How long, in seconds, would you like for your session? ");
        int userTimeDuration = int.Parse(Console.ReadLine());
        _timeDuration = userTimeDuration;
    }
}