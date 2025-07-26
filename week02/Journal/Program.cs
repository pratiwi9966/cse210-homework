using System;
using System.IO;
//what I have done to exceed requirements:
//1. Added support for saving and loading JSON files.
//2. Used Path.GetExtension to check the file type (ex: .txt or .json).
//3. Added EntryCount() method to Journal:
//   count how many journal entries exist.
//4. Improved DisplayAll() with a check for empty entries.   
//   it shows a message if there are no entries instead of doing nothing.

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
            Console.WriteLine("3. Save Journal to file(.txt, .CSV or .json)");
            Console.WriteLine("4. Load Journal from file(.txt, .CSV or .json)");
            Console.WriteLine("5. Exit ");
            Console.WriteLine("What do you like to do? \nEnter your choice (1-5): ");
            string choice = Console.ReadLine();


            if (choice == "1") //1. Write Journal
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"What is the weather now:  ");
                string weather = Console.ReadLine();
                Console.WriteLine($"How do you feel? (Happy, sad, etc.)  ");
                string mood = Console.ReadLine();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.WriteLine("Your thoughts: ");
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt"),
                    _weather = weather,
                    _mood = mood,
                    _promptText = prompt,
                    _entryText = response
                };

                myJournal.AddEntry(entry);
            }
            else if (choice == "2") //2. Display all Journal
            {
                int total = myJournal.EntryCount();
                Console.WriteLine($"You have written {total} entries");
                Console.WriteLine("All your Journal:\n");
                myJournal.DisplayAll();
            }
            else if (choice == "3") //3. Save Journal to file(.txt, .CSV or .json)
            {
                Console.Write("Enter filename to save (e.g., journal.txt, journal.csv, or journal.json): ");
                string filename = Console.ReadLine();

                //.GetExtension() the method is comes from .NET’s built-in library
                string extention = Path.GetExtension(filename).ToLower();

                if (myJournal.EntryCount() == 0)
                {
                    Console.WriteLine("No entries to save.");
                    continue; // skips the rest of the current loop and goes back to show the menu again.
                }

                // Checks if the file user typed in end is .json.
                //  If it’s not .json, then saves the file in text format (like .txt or .csv).
                if (extention == ".json")
                {
                    myJournal.SaveToJson(filename);
                }
                else
                {
                    myJournal.SaveToFile(filename);
                }
            }

            else if (choice == "4") //4. Load Journal from file(.txt, .CSV or .json)
            {
                Console.Write("Enter filename to load (e.g., journal.txt, journal.csv, or journal.json): ");
                string filename = Console.ReadLine();

                string extention = Path.GetExtension(filename).ToLower();

                if (extention == ".json")
                {
                    myJournal.LoadFromJson(filename);
                }
                else
                {
                    myJournal.LoadFromFile(filename);
                }
            }

            else if (choice == "5") //5. Exit 
            {
                Console.WriteLine("\nGoodbye! See you next time.\n ");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 5.\n");
            }
        }

    }

}
