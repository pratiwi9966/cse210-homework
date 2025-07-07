using System;
using System.Collections.Generic;

class Program

{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        Console.Write("\nEnter a list of numbers, type 0 when finished. ");
        Console.WriteLine();

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            // Only add the number to the list if it is not 0.
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"\nThe sum is: {sum}");

        // Part 2: Compute the average

        // (float)sum
        // This is a type cast — you're telling C#:
        // “Please convert sum (which is an int) into a float before doing the division.”
        // if you don’t cast it, C# will treat both sum and numbers.Count 
        // as integers and do integer division, which drops any decimal portion.

        // numbers.Count
        // This gets the number of elements in the List<int> numbers.
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

        }

        Console.WriteLine($"The max is: {max}");
        Console.WriteLine();


        // Sort the list in ascending order (smallest to largest)
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);

        }
        Console.WriteLine();
    }
}