
// Any class that has at least one abstract method is an Abstract class.
// An abstract class is like an incomplete blueprint.
// we cannot create a Shape object directly.
// Instead, we must create a child class (like Square, Rectangle, or Circle)
// that provides the missing pieces.
// In this case, one missing piece is: 
// how to calculate the area (because each shape has a different formula!).
public abstract class Shape
{
    // Member variable
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // getter and setter Method 
    // Get or change the color.
    public string GetColor() // read the color
    {
        return _color;
    }

    public void SetColor(string color) // change the color
    {
        _color = color;
    }

    //  abstract method
    // Every shape must define its own way of calculating area.
    // " every shape must know how to calculate its area, but I’m not going to do it here. 
    // You (child class) must do it yourself."
    public abstract double GetArea();

}