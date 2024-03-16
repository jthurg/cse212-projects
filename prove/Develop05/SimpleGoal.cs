public class SimpleGoal : Goal
{
    //Define member variables.
    //(n/a)
    
    //Define constructor.
    public SimpleGoal(string name, string description, int pointValue, bool isComplete)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _isComplete = isComplete;
    }

    //Define methods.
    public override void RecordEvent()
    {
        //Set isComplete to true.
        _isComplete = true;
    }

    public override int IsComplete()
    {
        //Return the point value.
        return _pointValue;
    }

    public override string GetGoalSummary()
    {
        string summary = $"{_name} ({_description})";
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
        
        string infoString = $"{GetType()}:{_name},{_description},{lowerComplete},{_pointValue}";
        return infoString;
    }
}