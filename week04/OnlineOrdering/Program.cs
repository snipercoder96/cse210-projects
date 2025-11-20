using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {

        // Testing procedure
        Address usaAddress = new Address("123 Long Street", "Springfield", "IL", "USA");
        Address internationalAddress = new Address("45 Market Road", "Cape Town", "Western Cape", "South Africa");

        // Testing procedure
        Customer customer1 = new Customer("Kevin", usaAddress);
        Customer customer2 = new Customer("Sarah", internationalAddress);

        // Testing procedure
        Product product1 = new Product("Laptop", 101, 800, 1);
        Product product2 = new Product("Mouse", 102, 20, 2);
        Product product3 = new Product("Keyboard", 103, 50, 1);

        // Testing procedure
        List<Product> order1Products = new List<Product> { product1, product2 }; // Shorthand for add to a list
        List<Product> order2Products = new List<Product> { product2, product3, product1 };

        // Testing procedure
        Order order1 = new Order(order1Products, customer1);
        Order order2 = new Order(order2Products, customer2);

        // How results for order #1
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: {order1.TotalCost()}\n");

        // Show results for order #2
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: {order2.TotalCost()}");
    }
}