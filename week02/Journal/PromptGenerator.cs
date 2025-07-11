using System;
using System.Collections.Generic;

public class PrompGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        _prompts.Add(
            "What did you learn from your scripture study today? How did it inspire you?"
            );
        _prompts.Add(
            "What is something you've been wanting to do but haven't had the chance? Why not?"
            );
        _prompts.Add(
            "What is one or two things you can do today to save more time for " +
            "studying or preparing your teaching materials?"
            );
        _prompts.Add(
            "What are some things that make you feel confident? Why do they have " +
            "that effect on you?"
            );
        _prompts.Add(
            "What is something you learned today that you could share with your family?"
            );
        _prompts.Add(
            "What is one thing you can do to feel more uplifted and spiritually " +
            "refreshed today? Why would that help?"
            );
        return "";//return a enpty string, make this no error
    }
    
}