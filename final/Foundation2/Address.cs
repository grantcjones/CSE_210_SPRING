using static System.Console;

public class Address{
    /*Creates an address object to be used in the Customer class*/

    // Initialize Class Attributes
    private string _streetAdd;
    private string _city;
    private string _state;
    private string _country;

    // Constructor(s)
    public Address(string streetAdd, string city, string state, string country) {
        _streetAdd = streetAdd;
        _city = city;
        _state = state;
        _country = country;
    }

    // Class Behaviors
    public string GetAddress() {
        /*Returns class attributes in a shipping address format*/
        return $"{_streetAdd}\n{_city}, {_state} {_country}";
    }

    public bool CheckUSA() {
        /*Returns whether an address is in the US or not.*/
        if (_country == "USA") {
            return true;
        }
        else {
            return false;
        }
    }
}