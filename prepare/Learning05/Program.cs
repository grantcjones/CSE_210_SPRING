using System;
using System.Globalization;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 14);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Green", 8, 6);
        shapes.Add(rectangle);

        Circle circle = new Circle("Black", 4.50);
        shapes.Add(circle);

        foreach (Shape shape in shapes) {
            WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }

    }
}