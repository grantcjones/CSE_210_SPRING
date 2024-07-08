using static System.Console;

public class Event{
    /*Superclass that creates an Event class object to represent an event*/

    // Initialize Class Attributes
    private string _eventType;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    // Constructor(s)
    public Event(string title, string description, string date, string time, string address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Class Behaviors
    public void SetType(string type) {
        /*SETS the type of event (designed to be used in sub-classes)*/
        _eventType = type;
    }

    public new string GetType() {
        /*Returns the type of event as a string*/
        return _eventType;
    }

    public void StandardDisplay() {
        /*PUTS the general details of an event to the terminal*/
        WriteLine($"      Title: {_title}");
        WriteLine($"Description: {_description}");
        WriteLine($"       Date: {_date}, {_time}");
        WriteLine($"    Address: {_address}");
    }

    public void ShortDisplay() {
        /*PUTS a very short list of deails to the terminal*/
        WriteLine($"       Type: {_eventType}\n      Title: {_title},\n       Date: {_date}");
    }
}