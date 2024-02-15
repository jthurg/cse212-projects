
using System.Security.Cryptography.X509Certificates;

public class Reference
{
    //Define member variables.
    private string _book;
    private string _chapter;
    private string _startVerseNum;
    private string _endVerseNum;

    //Define constructors.
    public Reference(string book, string chapter, string startVerse)
    {
       _book = book;
       _chapter = chapter;
       _startVerseNum = startVerse;
       _endVerseNum = "";
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
       _chapter = chapter;
       _startVerseNum = startVerse;
       _endVerseNum = endVerse;
    }
    public Reference()
    {

    }

    //Define methods.
    public string CreateReference()
    {
        //Create the reference string.
        string reference = _book + " " + _chapter + ":" + _startVerseNum;
        
        //Add the end verse number to the reference string if it exists
        if (_endVerseNum != "")
        {
            reference += "-" + _endVerseNum;
        }
        
        return reference;
    }

    public void DisplayReference()
    {
        //Display the correctly formatted reference.
        Console.Write($"{CreateReference()}: ");
    }
}