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
        : base("Reflection Activity", "This activity will help you reflect on your personal strength.")
    {   }

    //Method
    public void Run()
    {

    }

    public string GetRandomPrompt()
    {

    }

    public string GetRandomQuestion()
    {

    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    { 

    }


}

