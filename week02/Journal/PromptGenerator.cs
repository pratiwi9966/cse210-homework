using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Member variables 
    private List<string> _prompts;
    private Random _random;

    // Method
    public PromptGenerator()
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

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}