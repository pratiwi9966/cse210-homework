using System;

class Program
{
    // Main Function
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    // Function 1: Displays the message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("\nWelcome to the program! ");
    }

    // Function 2: Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // Function 3: Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    // Fuction 4: Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    //Function 5: Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the aquare of your number is {square}");
        Console.WriteLine();
    }
}