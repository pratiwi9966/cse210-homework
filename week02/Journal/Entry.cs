using System;
public class Entry
{
    // Member variables 
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;
    public string _weather;

    // Method
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