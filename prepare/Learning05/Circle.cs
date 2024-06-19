using static System.Console;

public class Circle : Shape {

    private double _radius;

    public Circle(double radius) {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.Pow(Math.PI * _radius, 2);
    }
}