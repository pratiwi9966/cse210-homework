using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    // List of entries(把每次輸入的內容當成1個項目存在_entries裡面)
    private List<Entry> _entries = new List<Entry>();

    // Add an entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all entry to the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display(); //Evrey journal the user wrote
        }
    }

    // Count the number of journal entries currently stored in the _entries list.
    public int EntryCount()
    {
        return _entries.Count;
    }

    // Save the journal entries to a file (txt)
    public void SaveToFile(string filename)
    {
        Console.WriteLine($"Saving {_entries.Count} entries to {filename}");
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._weather}|{entry._mood}|{entry._promptText}|{entry._entryText}");
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
                if (parts.Length == 5)
                // Ensures the line was split into exactly 5 parts: date, weather, mood, prompt, and response.
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _weather = parts[1],
                        _mood = parts[2],
                        _promptText = parts[3],
                        _entryText = parts[4]
                    };
                    _entries.Add(entry);//Adds the entry to the list for later use or display.
                }
            }
            Console.WriteLine($"Journal loaded successfully. {_entries.Count} entries found. \n");
        }
        else
        {
            Console.WriteLine("File not found.\n");
        }
    }

    // // Save the journal entries to a file (CSV))
    // public void SaveToCSV(string filename)
    // {
    //     using (StreamWriter writer = new StreamWriter(filename))
    //     {
    //         foreach (Entry entry in _entries)
    //         {
    //             writer.WriteLine($"{entry._date},{entry._weather},{entry._mood},{entry._promptText},{entry._entryText}");
    //         }
    //     }
    //     Console.WriteLine("Journal saved successfully.\n");

    // }

    // Save the journal entries to a JSON file
    public void SaveToJson(string filename)
    {
        Console.WriteLine($"Saving {_entries.Count} entries to JSON");
        // Turn the _entries list into a JSON string
        string jsonText = JsonSerializer.Serialize(_entries, new JsonSerializerOptions
        {
            WriteIndented = true // Makes the JSON easy to read
        });

        // Write the JSON string to the file
        File.WriteAllText(filename, jsonText);

        // Let the user know it's done
        Console.WriteLine("Journal saved to JSON.\n");
    }
    
    // Load entries from a JSON file
    public void LoadFromJson(string filename)
    {
        if (File.Exists(filename) == false)
        {
            Console.WriteLine("File not found. \n");
            return;
        }

        string jsonText = File.ReadAllText(filename);

        // Deserialize JSON text into the _entries list
        List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(jsonText);

        //If we successfully got entries from the file, and there’s at least one, 
        // let’s use them and show the user how many were loaded.
        //null = no data at all.
        if (loadedEntries != null && loadedEntries.Count > 0)
        {

            _entries = loadedEntries;
            //tells the user how many entries were loaded.
            Console.WriteLine($"Journal loaded from JSON. {_entries.Count} entries found.\n");
        }
        else
        { 
            Console.WriteLine("JSON loaded, but no entries found.\n");
        }  
        
    }
}