using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
       

        string choice = "";
        while (choice != "4")
        {
            Console.Clear(); // Clear the screen each time to keep it clean
            Console.WriteLine();
            Console.WriteLine("Mindfulness Program Demo");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Run Breathing Activity
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                Thread.Sleep(2000); // Pause for 2 seconds before showing menu
            }
            else if (choice == "2")
            {
                // Run Reflection Activity
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                Thread.Sleep(2000); // Pause for 2 seconds before showing menu
            }
            else if (choice == "3")
            {
                // Run Listing Activity
                ListingActivity listing = new ListingActivity();
                listing.Run();
                Thread.Sleep(2000); // Pause for 2 seconds before showing menu
            }

            else if (choice == "4")
            {
                Console.WriteLine("     \nGoodbye! Thanks for using Mindfulness Program. ");
                Thread.Sleep(1500); // Small pause before closing, gives the user time to read.
            }

            else
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4");
                Thread.Sleep(3000); // Pause for 3 seconds before showing menu 
            }



        }

    }
}