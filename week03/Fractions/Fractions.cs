using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Create Constructors
    public Fraction()
    {
        // initializes the number to 1/1 or Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1; // initializes the denominator to 1
    }

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

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }


}

