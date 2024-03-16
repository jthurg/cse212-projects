public class EternalGoal : Goal
{
    //Define member variables.
    //(n/a)
    
    //Define constructor.
    public EternalGoal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }

    //Define methods.
    public override void RecordEvent()
    {
        //Nothing happens here since there is no change to completion status
        //and the points are added in the IsComplete() method.
        //This is a placeholder for the function to work.
    }

    public override int IsComplete()
    {
        //Return the point value.
        //Completion status is not changed because the goal is eternal.
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