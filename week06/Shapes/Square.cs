
public class Square : Shape //nherit from Shape
{
    // Member variable
    private double _side; //stores the length of one side of the square

    //Constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Method 
    // The Shape class made this method abstract, which means every shape must write its own version.
    // override means giving Square's version of GetArea() here.
    // A square’s area is side × side, so we just return _side * _side.
    public override double GetArea()
    {
        return _side * _side;
    }
}