using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
       

        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Mindfulness Program Demo");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {

            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {

            }

            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            else if (choice != "4")// if it's not 1-3 and 4 (Quit), show error
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4");
                Thread.Sleep(2000); // Pause for 2 seconds before showing menu 
            }



        }

    }
}