using System;

// Define an interface
interface IShape
{
    double Area();
}

// Implement the interface in classes
class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area()
    {
        return Width * Height;
    }
}

class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of classes that implement the interface
        Rectangle rectangle = new Rectangle(5, 4);
        Circle circle = new Circle(3);

        // Calculate and display the area of each shape
        Console.WriteLine("Area of Rectangle: " + rectangle.Area());
        Console.WriteLine("Area of Circle: " + circle.Area());
    }
}
