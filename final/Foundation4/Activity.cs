using static System.Console;

public abstract class Activity{
    /*Creates an Activity class object to represent a physical activity performed at a fitness center,
    is a super-class*/

    // Initialize Class Attributes
    private string _dateTime;
    private double _duration;
    private string _activityType;

    // Constructor(s)
    public Activity(string dateTime, double duration) {
        _dateTime = dateTime;
        _duration = duration;
    }

    // Class Behaviors
    public void SetType(string type) {
        /*Returns the activity type as a string (designed to be 
        used within sub-classes)*/
        _activityType = type;
    }

    public double GetDuration() {
        /*Returns the duration of a physical activity in minutes as a double*/
        return _duration;
    }

    public double GetPace() {
        /*Calculates Returns the pace (min per km) as a double using 
        Activity class behavior GetSpeed*/
        return 60 / GetSpeed();
    }

    public void GetSummary() {
        /*PUTS a summary of a physical activity as a one-line string to the terminal*/
        WriteLine($"{_dateTime:0.00}, {_activityType}, ({_duration:0.00} min), Speed {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km");
    }

    // Polymorphic class behaviors
    public abstract double GetDistance(); // Returns the distance 'traveled' in a physical activity as a double

    public virtual double GetSpeed() {
        /*Calculates and Returns the speed at which a physical acitivty was 
        performed as a double using Activity class behavior GetDistance as a double*/
        return GetDistance() / _duration * 60;
    }
}