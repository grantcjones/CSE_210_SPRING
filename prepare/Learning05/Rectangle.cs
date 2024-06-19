using static System.Console;

public class Rectangle : Shape {

    private double _length;
    private double _width;
    
    public Rectangle(int length, int width) {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}
