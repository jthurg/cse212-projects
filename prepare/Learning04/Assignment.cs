public class Assignment
{
    //Define member variables.
    private string _studentName = "";
    private string _topic = "";

    //Define constructor.
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    //Define methods.
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetName()
    {
        return _studentName;
    }
}