using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("\nWhat is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Console.Write("What is your guess? ");
        // int guess = int.Parse(Console.ReadLine());
        // Console.WriteLine();

        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 101);

        int guess = -1;

        //keeps looping as long as the guess does not match the magic number
        while (guess != magicNumber)
        {
            Console.Write("\nWhat is the magic number? ");
            guess = int.Parse(Console.ReadLine());
            

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guess it! ");
                Console.WriteLine();
            }


        }


    }
}