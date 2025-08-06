
public class Rectangle : Shape //nherit from Shape
{
    // Member variable
    private double _lenght;
    private double _width;

    // Constructor
    public Rectangle(string color, double lenght, double width) : base(color)
    {
        _lenght = lenght;
        _width = width;
    }

    // Method 
    public override double GetArea()
    {
        return _lenght * _width;
    }
}