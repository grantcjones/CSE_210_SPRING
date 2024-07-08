using static System.Console;

public class Running : Activity{
    /*Creates a Running class object to represent a running activity, sub-class of Activity*/

    // Initialize Class Attribute(s)
    private double _distance;

    // Constructor(s) with reference to base class
    public Running(string dateTime, double duration, double distance) 
    : base(dateTime, duration) {
        SetType("Running");
        _distance = distance;
    }

    // Class Behaviors
    public override double GetDistance() {
        /*Overrides Abstract behavior GetDistance from Activity class, Returns the
        distance 'traveled' in running activity as a double*/
        return _distance;
    }

}