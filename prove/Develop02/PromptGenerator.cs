
using System.Runtime.InteropServices;

public class PromptGenerator
{
    //Define member variables.
    public List<string> _randomPrompts = new List<string>()
    {
        "What's your biggest takeaway from today?", 
        "How did you feel the Lord guiding you today?", 
        "Who was in your day that you are grateful for and why?", 
        "If you could relive today, what would you cut out from it?", 
        "On a scale of 1-10 how would you rate today and why?", 
        "What was the best thing someone said to you today?", 
        "How will you make tomorrow better from something you learned today?"
    };

    public string _generatedPrompt = "";
    //Define constructor.
    public PromptGenerator()
    {
    }

    //Define methods.
    public void DisplayRandomPrompt()
    {
        //Select a random prompt.
        var random = new Random();
        int index = random.Next(_randomPrompts.Count);
        string randomPrompt = _randomPrompts[index];
        Console.WriteLine(randomPrompt);
        _generatedPrompt  = randomPrompt;
    }
}