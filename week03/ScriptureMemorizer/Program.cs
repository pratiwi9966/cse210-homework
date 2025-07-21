using System;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Welcome to Scripture Memorizer program"); 

        // Step 1: Create a Reference object (book, chapter, startVerse, endVerse)endVerse(optional)
        Reference reference = new Reference("Doctrine and Covenants", 81, 5);

        // Step 2: Store the scripture text as a string
        string text = "Wherefore, be faithful; stand in the office which I have appointed unto you;\n"
                    + "succor the weak, lift up the hands which hang down, and strengthen the feeble knees.";

        // Step 3: Create a Scripture object using the reference and text
        Scripture scripture = new Scripture(reference, text);

        // Step 4: Start a loop that keeps running until all words are hidden
        while (scripture.IsCompletelyHidden() == false)
        {
            // Clear the screen before showing each new version
            Console.Clear();

            // Show the current state of the scripture
            Console.WriteLine(scripture.GetDisplayText());

            // Ask the user if they want to continue
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            // If the user types "quit", stop the program
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words before the next round
            scripture.HideRandomWords(1);
        }

        // After the loop is done (all words hidden), show final message
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nThanks for using this program!!.\n");
        Console.WriteLine("\n *******************************************************************\n");

    }
}