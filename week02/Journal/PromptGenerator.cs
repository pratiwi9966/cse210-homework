using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Member variables, private — only accessible inside this class.
    private List<string> _prompts; //stores all the possible journal prompts.
    private Random _random;

    // Method
    public PromptGenerator()//the constructor of the class
    {
        _random = new Random();
        _prompts = new List<string>
        {

            "What did you learn from your scripture study today? How did it inspire you?",
            "What is something you've been wanting to do but haven't had the chance? Why not?",
            "What is one or two things you can do today to save more time for " +
                "studying or preparing your teaching materials?",
            "What are some things that make you feel confident? Why do they have " +
                "that effect on you?",
            "What is something you learned today that you could share with your family?",
            "What is one thing you can do to feel more uplifted and spiritually " +
                 "refreshed today? Why would that help?"
        };
    }

    // Method
    public string GetRandomPrompt()
    {   //int index stores the random number into a variable named index.
        //_random is an object of the Random class, _prompts is a List<string>
        //.Count tells how many items are in that list.(the _prompts.Count is 6)
        int index = _random.Next(_prompts.Count);
        //_prompts[index] gets the string (prompt) at that position in the list.
        //Returns the string at the chosen index.
        return _prompts[index];
    }

}