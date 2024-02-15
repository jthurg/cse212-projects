
public class Word
{
    //Define member variables.
    private string _wordText;
    private bool _visible = true;

    //Define constructor.
    public Word(string word)
    {
        _wordText = word;
    }

    //Define methods.
    public string GetWordText()
    {
        return _wordText;
    }

    public void SetWordText(string word)
    {
        _wordText = word;
    }

    public void HideWord()
    {
        //Set _visible boolean to false.
        _visible = false;

        //Iterate through the length of the word and add an underscore
        //to the _newWord string. Then replace the old _wordText with
        //the new _newWord string.
        string _newWord = "";
        foreach (char letter in _wordText)
        {
            _newWord += "_";
        }
        _wordText = _newWord;
        }

    public void DisplayWord()
    {
        //Display the word.
        Console.Write($"{_wordText} ");
    }

    public bool GetVisibility()
    {
        //Return teh visibility boolean of the word.
        bool visibility = _visible;
        return visibility;
    }
    }
