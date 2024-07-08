using static System.Console;

public class Cycling : Activity{
    /*Creates a Cycling class object to reperesent a cycling acitivty, sub-class of Activity*/

    // Initialize Class Attribute(s)
    private double _speed;

    // Constructor(s) with reference to base class
    public Cycling(string dateTime, double duration, double speed) : base(dateTime, duration) {
        SetType("Cycling");
        _speed = speed;
    }

    // Class Behaviors
    public override double GetDistance() {
        /*Overrides abstract Activity class behavior GetDistance, 
        Calculates and Returns the distance 'traveled' in
        a cycling activity as a double using Activity class 
        behavior GetDuration*/
        return _speed * (GetDuration() / 60);
    }

    public override double GetSpeed() {
        /*Overrides abstract Activity class behavior GetDistance, 
        returns the speed of a cycling activity as a double*/
        return _speed;
    }
}