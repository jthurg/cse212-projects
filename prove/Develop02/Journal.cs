using System.Runtime.InteropServices;
using System.Security.Permissions;
using System;
using System.IO;

public class Journal
{
    //Define member variables.
    public List<Entry> _entries = new List<Entry>();

    //Create constructor.
    public Journal()
    {
    }

    //Define methods.
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void AddEntryToList(Entry entry) 
    {
        _entries.Add(entry);
    }

    public void LoadFromFile(string filename)
    {
        //Code to clear the _entries list.
        _entries.Clear();

        //Code to load the file typed.
        string[] lines = System.IO.File.ReadAllLines(filename);

        //Code to rip the info from the loaded file
        //and then write all the loaded
        //info to the empty list.
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string entryText = parts[1];
            string entryPrompt = parts[2];
            string entryMeal = parts[3];

            //Create an Entry object from each line in the file.
            Entry entry = new Entry();
            entry._date = date;
            entry._entryText = entryText;
            entry._entryPrompt = entryPrompt;
            entry._entryMeal = entryMeal;
            
            //Add the entry object to the empty list of _entries.
            AddEntryToList(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        //Code to write on the file the current
        //running list of _entries as lines where it is 
        //formatted "_date,_entryText,_entryPrompt,entryMeal".
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._entryText},{entry._entryPrompt},{entry._entryMeal}");
            }
        }
    }
}