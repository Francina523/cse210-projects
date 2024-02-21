using System;
using System.Collections.Generic;






class Program
{
    static void Main()
    {
        // Create address
        Address address1 = new Address
        {
            StreetAddress = "123 Main St",
            City = "Anytown",
            StateProvince = "CA",
            Country = "USA"
        };

        // Create customer
        Customer customer1 = new Customer
        {
            Name = "John Doe",
            Address = address1
        };

        // Create products
        Product product1 = new Product
        {
            Name = "Product A",
            ProductID = 1,
            Price = 10.99,
            Quantity = 2
        };

        Product product2 = new Product
        {
            Name = "Product B",
            ProductID = 2,
            Price = 5.99,
            Quantity = 3
        };

        // Create order
        Order order1 = new Order
        {
            Products = new List<Product> { product1, product2 },
            Customer = customer1
        };

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        // Create another order
        Address address2 = new Address
        {
            StreetAddress = "456 Elm St",
            City = "Othertown",
            StateProvince = "NY",
            Country = "Canada"
        };

        Customer customer2 = new Customer
        {
            Name = "Jane Smith",
            Address = address2
        };

        Product product3 = new Product
        {
            Name = "Product C",
            ProductID = 3,
            Price = 15.99,
            Quantity = 1
        };

        Order order2 = new Order
        {
            Products = new List<Product> { product3 },
            Customer = customer2
        };

        // Display order details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}