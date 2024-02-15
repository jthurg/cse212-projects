
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

public class Scripture
{
    //Define member variables.
    private List<Word> _verseText = new List<Word>();

    private string _reference;
    private List<int> _hiddenIndexes = new List<int>();


    //Define constructors.
    public Scripture()
    {
    }

    //Define methods.
    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public void DisplayText()
    {
        //Iterate through _verseText list to display the verse.
        foreach (Word word in _verseText)
        {
            word.DisplayWord();
        }
        //Spacing.
        Console.WriteLine();
        Console.WriteLine();
    }

    public void AddWordToList(Word word)
    {
        //Add the word to the _verseText list.
        _verseText.Add(word);
    }

    public void HideRandomWords()
    {
        //Check if all words are hidden.
        if (CheckIfAllHidden() == "quit")
        {
            //Clear the _hiddenIndexes list.
            _hiddenIndexes.Clear();
        }
        else
        {
            //Define a count variable and start a while loop.
            int count = 0;
            if (_verseText.Count - _hiddenIndexes.Count == 2)
            {
                count = 1;
            }
            else if (_verseText.Count - _hiddenIndexes.Count == 1)
            {
                count = 2;
            }

            while (count != 3)
            {
                //Define boolean for nested loop and generate a random index in the range of the 
                //string length of the verse.
                bool Next = false;
                Random random = new Random();
                int wordNum = random.Next(0, _verseText.Count);

                //Start a while loop to check if the word is already hidden.
                while (Next == false)
                {
                    if (_hiddenIndexes.Contains(wordNum))
                    {
                        //If the word is already hidden, generate a new index.
                        wordNum = random.Next(0, _verseText.Count);
                        Next = false;
                    }
                    else
                    {
                        //If the word is not hidden, hide it and add its index to the _hiddenIndexes list.
                        _hiddenIndexes.Add(wordNum);
                        _verseText[wordNum].HideWord();
                        Next = true;
                    }
                }
                //Add 1 to the count.
                count += 1;
            }
        }
        
    }

    public string CheckIfAllHidden()
    {
        //Define an empty string and a count variable.
        string entry = "";
        int falseCount = 0;
    
        //Iterate through each word in the _verseText list.
        foreach (Word word in _verseText)
        {
            if (word.GetVisibility() == false)
            {
                //Add 1 to the count if the word is already hidden.
                falseCount += 1;
            }
        }

        if (falseCount == _verseText.Count)
        {
            //If count variable is same length as length of the _verseText list, set entry to "quit".
            entry = "quit";
        }
        //Return entry.
        return entry;
    }
}