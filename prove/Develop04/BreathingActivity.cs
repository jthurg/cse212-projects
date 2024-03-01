public class BreathingActivity : Activity
{
    //Define member variables.
    //(n/a)

    //Define constructor.
    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
    }

    //Define methods.
    public void DisplayBreatheIn()
    {
        Console.Write("Breathe in...");
    }

    public void DisplayBreatheOut()
    {
        Console.Write("Breathe out...");
    }

    public void RunActivity()
    {
        //Display activity instructions.
        DisplayStartMessage();
        GetAndSetTimeDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseAndShowAnimation(5);
        Console.WriteLine();
        

        //Start time loop.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeDuration);
        while (DateTime.Now < endTime)
        {
            //Display the breathing in and out messages.
            Console.WriteLine();
            DisplayBreatheIn();
            PauseAndShowTimer(5);
            Console.WriteLine();
            DisplayBreatheOut();
            PauseAndShowTimer(5);
            Console.WriteLine();
        }

        //Display the end messages.
        Console.WriteLine();
        DisplayEndMessage();
    }
}