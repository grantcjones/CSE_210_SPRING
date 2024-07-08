using static System.Console;

public class Outdoor : Event{
    // Creates an Outdoor object to represent an outdoor event, subclass of Event

    // Initialize Class Attribute(s)
    private string _weather;

    // Constructor(s) with reference to base class
    public Outdoor(string title, string description, string date, string time, string address, string weather) 
    : base(title, description, date, time, address) {
        SetType("Outdoor");
        _weather = weather;
    }

    // Class Behaviors
    public string GetWeather() {
        /*Returns the type of weather forcasted for an outdoor event as a string*/
        return _weather;
    }

    public void DisplayFullDetails() {
        /*PUTS a full list of details of the outdoor event to the terminal using 
        Event class behavior StandardDisplay*/
        WriteLine($"       Type: {GetType()}");
        StandardDisplay();
        WriteLine($"    Weather: {_weather}");
    }

}