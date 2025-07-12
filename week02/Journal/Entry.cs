using System;
public class Entry
{
    // Member variables 
    public string _date;
    public string _promptText;
    public string _entryText;

    // Method
    public void Display()
    {
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine($"{_date} - \nPrompt - {_promptText}");
        Console.WriteLine($"Your thoughts: {_entryText}\n");
        Console.WriteLine("----------------------------------------------------------------------");
    }
}