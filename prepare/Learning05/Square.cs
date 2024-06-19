using static System.Console;

public class Square : Shape {
    private double _side;

    public Square(int side) {
        _side = side;
    }

    public override double GetArea() {
        return _side * _side;
    }
}