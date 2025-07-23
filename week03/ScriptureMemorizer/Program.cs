using System;

// This program helps users memorize a scripture.
// It displays a scripture (reference and text) and gradually hides random words.
// Each time the user presses Enter, more words are hidden.
// The program ends when all words are hidden or the user types "quit".
// It supports scriptures with single or multiple verses.
class Program
{
    static void Main(string[] args)
    {
       

        // Step 1: Create a Reference object (book, chapter, startVerse, endVerse)endVerse(optional)
        Reference reference = new Reference("Doctrine and Covenants", 81, 5);

        // Step 2: Store the scripture text as a string
        string text = "Wherefore, be faithful; stand in the office which I have appointed unto you;\n"
                    + "succor the weak, lift up the hands which hang down, and strengthen the feeble knees.";

        // Step 3: Create a Scripture object using the reference and text
        Scripture scripture = new Scripture(reference, text);
        
        // This keeps track of whether all the words have been hidden.
        // If true, it means the scripture was fully hidden and displayed the final message and can end the loop.
        bool allWordsHidden = false;

        // Step 4: Start a loop that keeps running until all words are hidden
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