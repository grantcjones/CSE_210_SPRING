using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {        
        // Create Order Class Objects
        Order order1 = new Order(new Customer("Bart", new Address("102 Surrey St", "Yamaha", "AL", "USA")));
        order1.AddProduct(new Product("lamp", "12Td", 34, 12));
        order1.AddProduct(new Product("Shelf", "cr8", 13, 2));
        order1.AddProduct(new Product("Action Figure", "007", 60, 1));

        Order order2 = new Order(new Customer("John", new Address("223 Little Whinging Ln", "London", "Greatershire", "UK")));
        order2.AddProduct(new Product("Wand", "W00D", 1, 45));
        order2.AddProduct(new Product("Broom", "5W33P", 2, 1243));
        order2.AddProduct(new Product("Quill", "Wr1t3", 3, 45));

        // Display a 'shipping' and a 'packing' label for the first 'Order' object
        WriteLine("Shipping:");
        order1.ShippingLabel();
        WriteLine("Contents:");
        order1.PackingLabel();
        WriteLine($"Order Cost: ${order1.TotalCost()}");

        WriteLine();

        // Display a 'shipping' and a 'packing' label for the second 'Order' object
        WriteLine("Shipping:");
        order2.ShippingLabel();
        WriteLine("Contents:");
        order2.PackingLabel();
        WriteLine($"Order Cost: ${order2.TotalCost()}");
    }
}