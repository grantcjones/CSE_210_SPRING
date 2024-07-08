using System.Runtime.CompilerServices;
using static System.Console;

public class Order{
    // Creates an Order object to represent a customer's order of a package of products for shipping

    // Initialize Class Attributes
    private List<Product> _products;
    private Customer _customer;

    // Constructor(s)
    public Order(Customer customer) {
        _products = [];
        _customer = customer;
    }

    // Class Behaviors
    public int TotalCost() {
        /*Calculates and Returns the total cost of an order including the cost of shipping
        (shipping cost is $5 for in the US and $35 for ouside
        of the US)*/
        int total = 0;
        if (_customer.IsUSA()) {
            total += 5;
        }
        else {
            total += 35;
        }
        foreach (Product product in _products) {
            total += product.ProductCost();
        }
        return total;
    }

    public void AddProduct(Product product) {
        /*Adds a Product class product to the order*/
        _products.Add(product);
    }

    public void PackingLabel() {
        /*PUTS the products in the order in a packing label format*/
        foreach (Product product in _products) {
            WriteLine($"{product.GetName()} - {product.GetId()}");
        }
    }

    public void ShippingLabel() {
        WriteLine($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }
}