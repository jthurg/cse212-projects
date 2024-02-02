

public class Entry
{
    //Define member variables.
    public string _date = "";
    public string _entryText = "";
    public string _entryPrompt = "";
    public string _entryMeal = "";

    //Create constructor.
    public Entry()
    {
    }

    //Define methods.
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_entryPrompt}");
        Console.WriteLine(_entryText);
        Console.WriteLine($"Meal of the Day: {_entryMeal}");
    }
}