using static System.Console;

public class Receptions : Event{
    // Creates a Receptions object to represent a reception event, subclass of Event

    // Initialize Class Attributes
    private List<string> _rsvp;
    private string _email;

    // Constructor(s) with reference to base class
    public Receptions(string title, string description, string date, string time, string address, string email) 
    : base(title, description, date, time, address) {
        SetType("Reception");
        _rsvp = [];
        _email = email;
    }

    // Class Behaviors
    public string GetEmail(){
        /*Returns the rsvp email as a string for guests to use*/
        return _email;
    }

    public void AddGuest(string guestName) {
        /*Adds a guest to the rsvp list
        (No need for integration with an actual rsvp email)*/
        _rsvp.Add(guestName);
    }

    public void DisplayFullDetails() {
        /*PUTS a full list of reception event details to the terminal using 
        Event class behavior StandardDisplay*/
        WriteLine($"       Type: {GetType()}");
        StandardDisplay();
        WriteLine($"RSVP email: {_email}");
    }

}