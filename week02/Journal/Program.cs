using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("====================================================================\n");
        Console.WriteLine("     *Welcome to Daily Journal App!*          ");
        Console.WriteLine("You'll receive a thoughtful prompt to help guide your reflection.");
        Console.WriteLine(
                          "Your response, along with the date and question, will be saved safely" +
                          " for you to revisit anytime.  "
                         );
        Console.WriteLine("\n====================================================================");


        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            //Show menu
            Console.WriteLine("\nPlease select one of the following options: ");
            Console.WriteLine("1. Write Journal");
            Console.WriteLine("2. Display all Journal");
            Console.WriteLine("3. Save Journal to file");
            Console.WriteLine("4. Load Journal from file");
            Console.WriteLine("5. Exit ");
            Console.WriteLine("What do you like to do? \nEnter your choice (1-5): ");
            string choice = Console.ReadLine();


            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"What is the weather today: ");
                string weather = Console.ReadLine();
                Console.WriteLine($"How do you feel today? (Happy, sad, etc.) ");
                string mood = Console.ReadLine();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.WriteLine("Your thoughts: ");
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _weather = weather,
                    _mood = mood,
                    _promptText = prompt,
                    _entryText = response
                };

                myJournal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                Console.WriteLine("All your Journal:\n");
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter filename to save (e.g. journal.txt):");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter filename to load (e.g., journal.txt):");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nGoodbye! See you next time.\n");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 5.\n");
            }
        }

    }

}
