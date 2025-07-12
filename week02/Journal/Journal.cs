using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // List of entries
    private List<Entry> _entries = new List<Entry>();

    // Add an entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all entry to the journal
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display(); //Evrey journal
        }
    }
    // Save the journal entries to a file 
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully.\n");
    }

    // Load entries from a file
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        // removes all elements from the list, we don’t duplicate old entries when loading a file.

        if (File.Exists(filename))
        //Exists() is a method that returns true or false,
        // prevents the program from crashing if the file doesn’t exist.
        {
            string[] lines = File.ReadAllLines(filename);
            //string[]: An array of strings, one line per element.
            //File.ReadAllLines(...): Reads all lines from the file and returns them as an array.

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                //line.Split('|'): Breaks the line into parts using | as the separator.
                if (parts.Length == 3)
                //Ensures the line was split into exactly 3 parts: date, prompt, and response.
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(entry);//Adds the entry to the list for later use or display.
                }
            }
            Console.WriteLine("Journal loaded successfully.\n");
        }
        else
        {
            Console.WriteLine("File not found.\n");
        }
    }
}