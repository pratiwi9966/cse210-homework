using System;
public class Entry
{
    // Member variables (Properties) use get; set;
    // These let the program *save*(serialization) and *load*(deserialization) the data.
    // When saving to a JSON file, the computer needs to "get" the values.
    // When loading from a JSON file, it needs to "set" the values.
    // If we don’t use get; set;, the program(System.Text.Json) can’t save or load the data correctly.

    //allows JSON to read and write the date of the entry.
    public string _date { get; set; } 
    public string _promptText { get; set; }
    public string _entryText { get; set; }
    public string _mood { get; set; }
    public string _weather { get; set; }

    // Method, prints the contents of the entry to the console.
    public void Display()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine($"{_date} - Weather: {_weather}");
        Console.WriteLine($"How do you feel today? (Happy, sad, etc.){_mood} ");
        Console.WriteLine($"Prompt - {_promptText}");
        Console.WriteLine($"Your thoughts: {_entryText}\n");
        Console.WriteLine("----------------------------------------------------------------------");
    }
}