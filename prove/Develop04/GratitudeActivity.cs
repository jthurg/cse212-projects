using System.Runtime.CompilerServices;

public class GratitudeActivity : Activity
{
    //Define member variables.
    //(n/a)

    //Define constructor.
    public GratitudeActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
    }

    //Define methods.
    public void RunActivity()
    {
        //Display the instructions.
        DisplayStartMessage();
        GetAndSetTimeDuration();
        Console.Clear();
        Console.WriteLine("Take a moment to think about things in your life you were grateful for today.");
        PauseAndShowAnimation(10);
        Console.WriteLine();
        Console.WriteLine($"Now take the next {_timeDuration.ToString()} seconds to record some of the things you thought of that you are grateful for.");
        Console.Write("You may start in: ");
        PauseAndShowTimer(5);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Things I'm Grateful For: ");

        //Start the time loop.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeDuration);
        while (DateTime.Now < endTime)
        {
            //Allow user to record things they are grateful for.
            Console.Write("> ");
            Console.ReadLine();
        }
        
        //Display the end messages.
        Console.WriteLine();
        Console.WriteLine("Thank you for your participation. Remember that God will bless you for taking time to acknowledge the blessings He has given you.");
        PauseAndShowAnimation(5);
        Console.WriteLine();
        DisplayEndMessage();
    }
}