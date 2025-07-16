using System;

class Program
{   // The entry point of the program. This is where everything starts.
    static void Main(string[] args)
    {
        // Creates a fraction f1 using the default constructor → 1/1.
        Fraction f1 = new Fraction();
        // Prints "1 / 1".
        Console.WriteLine(f1.GetFractionString());
        //Prints 1.0.
        Console.WriteLine(f1.GetDecimalValue());

        // Creates a fraction f2 using the whole number constructor → 5/1.
        Fraction f2 = new Fraction(5);
        // Prints "5 / 1".
        Console.WriteLine(f2.GetFractionString());
        // Prints 5.0.
        Console.WriteLine(f2.GetDecimalValue());

        // Creates a fraction f3 with top = 3 and bottom = 4 → 3/4.
        Fraction f3 = new Fraction(3,4);
        // Prints "3 / 4".
        Console.WriteLine(f3.GetFractionString());
        // Prints 0.75.
        Console.WriteLine(f3.GetDecimalValue());

        //Creates a fraction f4 as 1/3.
        Fraction f4 = new Fraction(1,3);
        // Prints "1 / 3".
        Console.WriteLine(f4.GetFractionString());
        // Prints something like 0.3333333333333333.
        Console.WriteLine(f4.GetDecimalValue());

    }
}