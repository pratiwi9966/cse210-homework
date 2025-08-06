using System;

class Program
{
    static void Main(string[] args)
    {
        // created a list to store different shapes.
        List<Shape> shapes = new List<Shape>();

        // Each shape is added to the list using its constructor.
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        // looping through a list of shapes (circles, rectangles, squares), and for each shape I got
        //  Get its color, calculate its area, and display the result on the screen
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor(); //stores the answer into a variable 'color'.

            double area = shape.GetArea(); // store the answer in to variable 'area'.
            // This line is asking the shape: “What is your area?”
            // The method GetArea() is different for each shape
            // square multiplies side × side
            // rectangle multiplies length × width
            // circle uses π × radius^2

            Console.WriteLine($"The {color} shape has an area of {area}");

        }
    }
}