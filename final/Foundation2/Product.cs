using static System.Console;

public class Product{
    // Creates an object to represent a product, to be used in Order class

    // Initialize Class Attributes
    private string _name;
    private string _productId;
    private int _unitPrice;
    private int _quantity;

    // Constructor(s)
    public Product(string name, string productId, int unitPrice, int quantity) {
        _name = name;
        _productId = productId;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    // Class Behaviors
    public string GetId() {
        /*Returns a product's ID number*/
        return _productId;
    }

    public string GetName() {
        /*Returns a product's name*/
        return _name;
    }

    public int ProductCost() {
        /*Calculates and Returns the cost of a quantity of products in an order*/
        return _unitPrice * _quantity;
    }
}