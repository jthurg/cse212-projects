public class ChecklistGoal : Goal
{
    //Define member variables.
    private int _bonusPoints = 0;
    private int _timesHaveAccomplished = 0;
    private int _timesNeedAccomplished = 0;

    //Define constructor.
    public ChecklistGoal(string name, string description, int pointValue, bool isComplete, int timesHaveAccomplished, int timesNeedsAccomplished, int bonusPoints)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _isComplete = isComplete;
        _timesHaveAccomplished = timesHaveAccomplished;
        _timesNeedAccomplished = timesNeedsAccomplished;
        _bonusPoints = bonusPoints;
    }
    //Define methods.
    public override void RecordEvent()
    {
        //Add 1 to the timesHaveAccomplished and if it is equal to timesNeedAccomplished, set isComplete to true.
        _timesHaveAccomplished += 1;
        if (_timesHaveAccomplished == _timesNeedAccomplished)
        {
            _isComplete = true;
        }
    }

    public override int IsComplete()
    {
        //If timesHaveAccomplished is equal to timesNeedAccomplished,
        //return the point value plus the bonus points.
        //Otherwise, return the base point value.
        int points = _pointValue;
        if (_timesHaveAccomplished == _timesNeedAccomplished)
        {
            points += _bonusPoints;
        }
        return points;
        
    }

    public void SetTimesNeedAccomplished()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _timesNeedAccomplished = int.Parse(Console.ReadLine());
    }

    public void SetBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

    }

    public override string GetGoalSummary()
    {
        string summary = $"{_name} ({_description}) -- Currently completed: {_timesHaveAccomplished}/{_timesNeedAccomplished}";
        return summary;
    }

    public override string GetStringRepresentation()
    {
        //Convert Boolean to lowercase.
        string lowerComplete = "";
        if (_isComplete == true)
        {
            lowerComplete = "true";
        }
        else
        {
            lowerComplete = "false";
        }

        string infoString = $"{GetType()}:{_name},{_description},{lowerComplete},{_pointValue},{_bonusPoints},{_timesHaveAccomplished},{_timesNeedAccomplished}";
        return infoString;
    }
}