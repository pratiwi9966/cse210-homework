using System;

public class Fraction
{   // member variables
    private int _top;
    private int _bottom;

    // Create Constructors  This is a default constructor.
    // If no values are provided, the fraction defaults to 1/1.
    public Fraction()
    {
        // initializes the number to 1/1 or Default to 1/1
        _top = 1;
        _bottom = 1;
    }
    // This allows creating a whole number as a fraction, like 5 → 5/1.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1; // initializes the denominator to 1
    }
    // This allows full control: you pass both the numerator and denominator, e.g., 3/4.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Method 
    public string GetFractionString()
    {
        string text = $"{_top} / {_bottom}";
        return text;
    }
    // Calculates the decimal value of the fraction (e.g., 3/4 → 0.75).
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }


}

