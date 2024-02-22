public class MathAssignment : Assignment
{
    //Define member variables.
    private string _textbookSection = "";
    private string _problems = "";

    //Define constructor.
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //Define methods.
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}