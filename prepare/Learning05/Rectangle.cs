using static System.Console;

public class Rectangle : Shape {

    private double _length;
    private double _width;
    
    public Rectangle(string color, int length, int width) 
        : base(color) {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}
