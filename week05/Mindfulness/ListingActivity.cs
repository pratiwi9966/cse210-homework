public class ListingActivity : Activity
{
    // Member variables
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    //Constructor
    public ListingActivity()
        : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by" +
        "having you list as many things as you can in a certain area.")
    {

    }

    // Methods
    // Get a random prompt from the list
    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        int index = prompt.Next(_prompts.Count);
        return _prompts[index];
    }

    // Collects user input for a set amount of time
    public List<string> GetListFromUser()
    {
        // Figures out when to stop the activity.
        DateTime stopTime = DateTime.Now.AddSeconds(_duration);
        //DateTime.Now is the current time.
        //AddSeconds(_duration) means: add the number of seconds stored in _duration to the current time.
        // stopTime = the moment when time will be up.

        // Creates a new empty list to store the user's responses.
        List<string> userResponses = new List<string>();

        // a loop that keeps running until the time is up.
        while (DateTime.Now < stopTime)
        {
            // Show a simple prompt symbol so the user knows where to type
            Console.Write("> ");
            string userResponse = Console.ReadLine(); // Read what the user typed

            // Check if the user typed something (not empty or just spaces)
            bool hasText = !string.IsNullOrWhiteSpace(userResponse);

            if (hasText)
            {
                userResponses.Add(userResponse);  // Add the userresponse to the list
            }
        }

        // After time runs out, return the full list of userResponses
        return userResponses;
    }

    public void Run()
    {
        DisplayStartingMessage(); //Ask user how long to run

        string prompt = GetRandomPrompt();  // Choose a random prompt from the list

        //Show the prompt to the user
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");

        // Countdown before starting the activity
        ShowCountDown(5);
        Console.WriteLine();

        // Get the user's list of responses
        List<string> userResponses = GetListFromUser();

        // Count how many responses from user
        _count = userResponses.Count;

        // Show how many items the user listed
        Console.WriteLine($"\nYou listed {_count} responses!");

        DisplayEndingMessage();
    }

    

}
