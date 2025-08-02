using System;
using System.Threading; //uses Thread.Sleep() to pause the program temporarily

public class Activity
{
    // Member variables
    private string _ActivityName; 
    private string _ActivityDescription; 
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
        Console.WriteLine($"~ Welcome to the {_ActivityName}. ~ ");
        Console.WriteLine(_ActivityDescription);
        Console.WriteLine("How long in seconds, would you like for your section ?");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3); // Called BEFORE the method is defined in code
                        // calls the ShowSpinner method, run for 3 seconds
    }

    public void DisplayEndingMessage(string ActivityName)
    {
        Console.WriteLine("\n Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_ActivityName}");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        // creates an array of spinner symbols( Spinner characters).
        string[] symbols = {"|","/","-","\\",};
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
            Console.WriteLine(symbols[index]);
            // pauses the program for 250 milliseconds (0.25 seconds) so we can see the animation 
            Thread.Sleep(250);
            // Erase the spinner symbol
            Console.Write("\b \b");
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
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }
}