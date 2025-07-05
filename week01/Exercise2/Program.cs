using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nWhat is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        //initialize the letter and sign
        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine + or - sign 
        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        //Determine No A+ and F+- sign
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        //display Letter and Signs
        Console.WriteLine($"Your grade is: {letter}{sign}");
        Console.WriteLine();

        //words for the user
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Better luck next time!");
            Console.WriteLine("");
        }
    }
}