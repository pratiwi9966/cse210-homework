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


        string playAgain;

        do
        {

            // For Part 3, Generate a random magic number between 0–100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(0, 101);

            int guess = -1;
            int guessCount = 0;

            //keeps looping as long as the guess does not match the magic number
            while (guess != magicNumber)
            {
                Console.Write("\nWhat is the magic number? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;


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
                    Console.WriteLine($"You guess it! \nIt took you {guessCount} guesses!");
                    Console.WriteLine();
                }
            }
            //Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
            Console.WriteLine();

        }
        while (playAgain == "yes" || playAgain == "y");

        Console.WriteLine("Thanks for playing!");
        Console.WriteLine();
    }
}