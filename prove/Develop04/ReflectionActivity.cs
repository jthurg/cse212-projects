using System.ComponentModel.DataAnnotations;

public class ReflectionActivity : Activity
{
    //Define member variables.
    private List<string> _promptList = new List<string>{"Think of a time when you stood up for someone else.", 
    "Think of a time when you did something really difficult.", 
    "Think of a time when you helped someone in need.", 
    "Think of a time when you did something truly selfless."};
    private List<string> _questionList = new List<string>{"Why was this experience meaningful to you?", 
    "Have you ever done anything like this before?", 
    "How did you get started?", 
    "How did you feel when it was complete?", 
    "What made this time different than other times when you were not as successful?", 
    "What is your favorite thing about this experience?", 
    "What could you learn from this experience that applies to other situations?", 
    "What did you learn about yourself through this experience?", 
    "How can you keep this experience in mind in the future?"};
    private string _randomPrompt = "";
    private string _randomQuestion = "";

    //Define constructor.
    public ReflectionActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
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
    
    public void SetRandomQuestion()
    {
        //Select a random question and save it in the _randomQuestion variable.
        Random random = new Random();
        int questionNum = random.Next(0, _questionList.Count);
        _randomQuestion = _questionList[questionNum];
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
        GetRandomPrompt();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.Write("--- ");
        DisplayRandomPrompt();
        Console.WriteLine(" ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        PauseAndShowTimer(5);
        Console.Clear();

        //Start the time loop.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeDuration);
        while (DateTime.Now < endTime)
        {
            //Display random questions to the user.
            SetRandomQuestion();
            Console.Write($"> {_randomQuestion} ");
            PauseAndShowAnimation(5);
            Console.WriteLine();
        }

        //Display the end messages.
        Console.WriteLine();
        DisplayEndMessage();
    }
}