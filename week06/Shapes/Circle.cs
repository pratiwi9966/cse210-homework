
public class Circle : Shape //nherit from Shape
{
    // Member variable
    private double _radius;

    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    
    //Method
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}