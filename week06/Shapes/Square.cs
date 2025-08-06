
public class Square : Shape //nherit from Shape
{
    // Member variable
    private double _side;

    //Constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Method 
    public override double GetArea()
    {
        return _side * _side;
    }
}