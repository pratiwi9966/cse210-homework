using System;
using System.Threading;

public class BreathingActivity : Activity
{
    //no member variables


    // Constructor
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax through deep breathing.")
    { }

    //Method to run the Breathing Activity
    public void Run()
    {
        DisplayStartingMessage(); // Ask user for duration, display intro
        // Adds a number of seconds (stored in _duration) to the current time.
        // ex: if _duration is 10, then it calculates the time 10 seconds into the future.
        DateTime stopTime = DateTime.Now.AddSeconds(_duration);
        // Stores that future time in a new variable 'stopTime'.
        // says the time when the activity should end.

        while (DateTime.Now < stopTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.Write("\nNow breathe out...");
            ShowCountDown(3);
            Console.WriteLine("\n\n");

            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.Write("\nNow breathe out...");
            ShowCountDown(6);
            Console.WriteLine("\n\n");

            Console.Write("Breathe in...");
            ShowCountDown(6);
            Console.Write("\nNow breathe out...");
            ShowCountDown(4);
            Console.WriteLine("\n\n");
        }

        DisplayEndingMessage(); // call method from Activity class
        // Log the activity automatically
        LogActivity();

    }

        
    

}