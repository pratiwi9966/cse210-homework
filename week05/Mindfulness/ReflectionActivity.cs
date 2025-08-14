using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    //Member variables
    private List<string> _prompts = new List<string>
    {
         "Think of a time when you stood up for someone else.",
         "Think of a time when you did something really difficult.",
         "Think of a time when you helped someone in need.",
         "Think of a time when you did something truly selfless."

    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "What did you learn about yourself?",
        "What could you learn from this experience?"
    };

    // Costructor
    public ReflectionActivity()
        : base("Reflection Activity",
         "This activity will help you reflect on times in your life when you have shown strength"+
         "and resilience. This will help you recognize the power you have and how you can use it"+
         "in other aspects of your life..")
    { }

    //Method
    // Picks a random prompt from the list
    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        int index = prompt.Next(_prompts.Count);
        return _prompts[index];
    }

    // Picks a random question from the list
    public string GetRandomQuestion()
    {
        Random question = new Random();
        int index = question.Next(_questions.Count);
        return _questions[index];
    }

    // Displays a random prompt
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.WriteLine();
    }

    public void DisplayQuestion()
    {
        string prompt = GetRandomPrompt();
        Console.Write($"\n> {prompt} ");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void Run()
    {
        DisplayStartingMessage(); // Ask user for duration, display message

        DisplayPrompt(); // Show one random prompt
        Console.WriteLine("When you have something in mind, press 'Enter' to continue.");
        Console.ReadLine(); // Wait for the user to press Enter

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: "); ShowCountDown(5);


        DisplayQuestion(); // Show one random qestion

        ShowSpinner(_duration); // Spinner simulates reflection time

        // // Calculate when the activity should end
        // DateTime stopTime = DateTime.Now.AddSeconds(_duration);

        // while (DateTime.Now < stopTime)
        // {
        //     DisplayQuestion();
        // }

        DisplayEndingMessage(); // call method from Activity class
        // Log the activity automatically
        LogActivity();
    }

}

