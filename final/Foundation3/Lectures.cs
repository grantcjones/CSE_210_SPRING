using static System.Console;

public class Lectures : Event{
    // Creates a Lectures object to represent a lecture event, subclass of Event

    // Initialize Class Attributes
    private string _speaker;
    private int _capacity;

    // Constructor(s) with reference to base class
    public Lectures(string title, string description, string date, string time, string address, string speaker, int capacity) 
    : base( title, description, date, time, address) {
        SetType("Lecture");
        _speaker = speaker;
        _capacity = capacity;
    }

    // Class Behavior(s)
    public void DisplayFullDetails() {
        /*PUTS a full list of lecture event details to the terminal using Event class behavior StandardDisplay*/
        WriteLine($"       Type: {GetType()}");
        StandardDisplay();
        WriteLine($"    Speaker: {_speaker}");
        WriteLine($"   Capacity: {_capacity}");
    }
}