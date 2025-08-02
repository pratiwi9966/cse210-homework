using System;
// exceed requirements:
// I added two more scriptures to let the program randomly choose one to show.
class Program
{
    static void Main(string[] args)
    {
        //Create a list to store the scripture library
        List<Scripture> scriptureLibrary = new List<Scripture>();

        // first scripture
        //Create a Reference object (book, chapter, startVerse, endVerse)endVerse(optional)
        Reference reference1 = new Reference("Doctrine and Covenants", 81, 5);

        // Store the scripture text as a string
        string text1 = "Wherefore, be faithful; stand in the office which I have appointed unto you;\n"
                    + "succor the weak, lift up the hands which hang down, and strengthen the feeble knees.";

        // Create a Scripture object using the reference and text
        Scripture scripture1 = new Scripture(reference1, text1);

        //second scripture
        Reference reference2 = new Reference("Doctrine and Covenants", 84, 106);
        string text2 = "And if any man among you be strong in the Spirit, let him take with him;\n"
                    + "him that is weak, that he may be edified in all meekness, that he may become strong also.";
        Scripture scripture2 = new Scripture(reference2, text2);

        //third scripture
        Reference reference3 = new Reference("2 Nephi", 32, 3);
        string text3 = "Angels speak by the power of the Holy Ghost; wherefore, they speak the\n"
                 + "words of Christ. Wherefore, I said unto you, feast upon the words of Christ; \n"
                 + "for behold, the words of Christ will tell you all things what ye should do.";
        Scripture scripture3 = new Scripture(reference3, text3);

        // Add all scriptures to a list (scripture library)
        scriptureLibrary.Add(scripture1);
        scriptureLibrary.Add(scripture2);
        scriptureLibrary.Add(scripture3);

        // Pick a random scripture from the list
        Random rand = new Random();
        int index = rand.Next(scriptureLibrary.Count); // Get a random index
        Scripture scripture = scriptureLibrary[index]; // Get a random scripture

        // // A list of motivational messages to help the user stay encouraged
        // List<string> encouragementMessages = new List<string>()
        // {
        //     "Practice makes progress!",
        //     "Nice work, keep it up!",
        //     " You're learning fast!",
        //     "Don't stop now!",
        //     "Fantastic progress!"
        // };

        // // This number will help us track how many times the user has pressed Enter
        // int roundCount = 0;

        // // Add 1 to the counter each round
        // roundCounter++;

        // // Every 2 rounds, show a motivational message
        // if (roundCounter % 2 == 0) // This means every 2nd round
        // {
        //     int messageIndex = roundCounter / 2 - 1;

        //     // Only show a message if we have one available in the list
        //     if (messageIndex < encouragementMessages.Count)
        //     {
        //         Console.WriteLine("\n----------------------------------------------");
        //         Console.WriteLine(encouragementMessages[messageIndex]); // Show the message
        //         Console.WriteLine("Press Enter to continue...");
        //         Console.ReadLine(); // Wait for the user to press Enter
        //     }
        // }

        // This keeps track of whether all the words have been hidden.
        // If true, it means the scripture was fully hidden and displayed the final message and can end the loop.
        bool allWordsHidden = false;

        //Start a loop that keeps running until all words are hidden
        //Keep looping while the scripture is not completely hidden.
        while (scripture.IsCompletelyHidden() == false)
        {
            // Clear the screen before showing each new version
            Console.Clear();

            // Show the current state of the scripture
            Console.WriteLine(scripture.GetDisplayText());

            // Ask the user if they want to continue
            Console.WriteLine("\nPress Enter to continue hide words or type 'quit' to exit:");
            string input = Console.ReadLine();


            // If the user types "quit", stop the program
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 4 random words before the next round
            scripture.HideRandomWords(4);

            // Check if all words are hidden.
            // If they are, clear the screen, show the fully hidden scripture,
            // display a Good Job message, set 'allWordsHidden' to true, and exit the loop.
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll the words are now hidden. Good Job!");
                allWordsHidden = true;
                Console.WriteLine("\n ***************************************************************\n");
                break;
            }

        }

        // Final message (only if user quit early)
        if (allWordsHidden == false)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nThanks for using this program!!.\n");
            Console.WriteLine("\n *******************************************************************\n");
        }

    }
}