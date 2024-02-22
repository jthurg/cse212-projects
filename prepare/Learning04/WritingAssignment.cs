public class WritingAssignment : Assignment
{
    //Define member variables.
    private string _title = "";

    //Define constructor.
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    //Define methods.
    public string GetWritingInformation()
    {
        return $"{_title} by {GetName()}";
    }
    
}