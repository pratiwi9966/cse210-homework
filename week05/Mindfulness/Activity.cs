using System;
using System.Threading; //uses Thread.Sleep() to pause the program temporarily

public class Activity
{
    // Member variables
    private string _ActivityName;
    private string _ActivityDescription;
    protected string _logFile = "activity_log.txt";
    protected int _duration; // stores how long the activity should run.
    // Making it protected means that derived classes can access and use it directly 
    // without needing a getter or setter.

    // Constructor: the _duration is not include because the user is asked to enter the duration 
    // before the activity starts.So instead of passing it in the constructor, it's set afterward.
    public Activity(string ActivityName, string ActivityDescription)
    {
        _ActivityName = ActivityName;
        _ActivityDescription = ActivityDescription;
    }

    // Method
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"~ Welcome to the {_ActivityName}. ~\n ");
        Console.WriteLine($"{_ActivityDescription}");
        Console.Write("\nHow long in seconds, would you like for your section?  ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3); // Called BEFORE the method is defined in code
                        // calls the ShowSpinner method, run for 3 seconds
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        // creates an array of spinner symbols( Spinner characters).
        string[] symbols = { "|", "/", "-", "\\", };
        // Calculate when the spinner should stop
        DateTime stopTime = DateTime.Now.AddSeconds(seconds);
        // DateTime.Now gets the current time.
        // AddSeconds(seconds) adds the number of seconds passed into the method.
        // The result is the stoptime — when the spinner should stop.
        // Example: If seconds = 3, this sets stopTime to 3 seconds in the future.

        // Start at the first symbol
        int index = 0;

        // This loop continues as long as the current time is before the stop time.
        // and keeps spinning until the requested time (in seconds) is up.
        while (DateTime.Now < stopTime)
        {
            // Show the current spinner symbol
            Console.Write(symbols[index]);
            // pauses the program for 250 milliseconds (0.25 seconds) so we can see the animation 
            Thread.Sleep(350);
            Console.Write("\b \b");// Erase the spinner symbol
            // Move to the next symbol (loop back to the start if needed)
            index++;

            // If we reached the end of the array, start over
            if (index >= symbols.Length)
            {
                index = 0;
            }
        }

    }

    // public void ShowSpinner(int seconds)
    // {
    //     for (int i = 0; i < seconds; i++)
    //     {
    //         Console.Write("/"); Thread.Sleep(250); Console.Write("\b");
    //         Console.Write("-"); Thread.Sleep(250); Console.Write("\b");
    //         Console.Write("\\"); Thread.Sleep(250); Console.Write("\b");
    //         Console.Write("|"); Thread.Sleep(250); Console.Write("\b");
    //     }
    // }

    public void ShowCountDown(int seconds)
    {
        // Start countdown from 'seconds', decreasing by 1 each time.
        //secondsLeft starts at the input number and counts down to 1.
        for (int secondsLeft = seconds; secondsLeft > 0; secondsLeft--)
        {
            // Print the current number (like 5, 4, 3...)
            Console.Write($"{secondsLeft}");// Show countdown with dots
            // Pauses the program for 1 second so the number stays visible.
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the number from the screen
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n Well done!!\n");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_ActivityName}");
        ShowSpinner(2);
    }

    public List<string> LoadLog()
    {
        // Creates a new empty list of strings. This will store all the lines from log file.
        List<string> activityLogs = new List<string>();

        // Checks if the file specified by _logFile exists.
        if (File.Exists(_logFile))
        {
            //Reads all lines from the file at once and puts them into a string array.
            //Each line in the file becomes one element in the lines array.
            string[] lines = File.ReadAllLines(_logFile);
            //Loops through every line from the file.
            foreach (string line in lines)
            {
                //Adds each line from the file into activityLogs list.
                activityLogs.Add(line);
            }
        }
        //Returns the list to wherever the method was called,
        //now we have a list of all previous activity logs in memory.
        return activityLogs;
    }

    public void LogActivity()
    {
        //Creates a single line of text for the log file.
        string logEntry = $"{DateTime.Now} | {_ActivityName} | Duration: {_duration} seconds";

        // Add the log entry to the log file
        using (StreamWriter writer = new StreamWriter(_logFile, true)) // true = append, don’t overwrite
        {
            writer.WriteLine(logEntry);
        }

        Console.WriteLine("Activity logged successfully.\n");
    }

}