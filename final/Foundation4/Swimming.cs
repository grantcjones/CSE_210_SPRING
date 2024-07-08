using static System.Console;

public class Swimming : Activity{
    /*Creates a Swimming class object used to represent a swimming activity, sub-class of Activity*/

    // Initialize Class Attributes
    private float _laps;
    private float _lapLength = 50;

    // Constructor(s) with reference to base class
    public Swimming(string dateTime, float duration, float laps) : base(dateTime, duration) {
        SetType("Swimmming");
        _laps = laps;
    }

    // Class Behavior(s)
    public override double GetDistance() {
        /*Overrides Abstract behavior GetDistance from 
        Activity class, Calculates and Returns the distance 
        'traveled' in swimming activity as a double*/
        return _laps * _lapLength / 1000;
    }

}