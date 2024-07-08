using static System.Console;
public class Customer{
    /*Creates an object to represent a customer, to be used in the Order class*/

    // Initialize Class Attributes
    private string _name;
    private Address _address;

    // Constructor(s)
    public Customer(string name, Address address) {
        _name = name;
        _address = address;
    }

    // Class Behaviors
    public string GetName() {
        /*Returns customer's name*/
        return _name;
    }

    public string GetAddress() {
        /*Returns customer's address in shipping format using 
        GetAddress from Address class*/
        return _address.GetAddress();
    }

    public bool IsUSA() {
        /*Returns whether an address is in the US using CheckUSA
        from Address class*/
        if (_address.CheckUSA()) {
            return true;
        }
        else {
            return false;
        }
    }
}