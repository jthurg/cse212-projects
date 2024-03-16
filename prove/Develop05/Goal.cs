public abstract class Goal
{
    //Define member variables.
    protected string _name = "";
    protected string _description = "";
    protected int _pointValue = 0;
    protected bool _isComplete = false;

    //Define constructor.
    public Goal()
    {
    }

    //Define methods.
    public void SetName()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
    }

    public void SetPointValue()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        _pointValue = int.Parse(Console.ReadLine());
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetPointValue()
    {
        return _pointValue;
    }

    public abstract void RecordEvent();

    public abstract int IsComplete();

    public bool GetIsComplete()
    {
        return _isComplete;
    }
    
    public abstract string GetGoalSummary();

    public abstract string GetStringRepresentation();
}   