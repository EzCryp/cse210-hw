using System;

class Program
{
    static void Main(string[] args)
    {
       // Creating Address, Customer, and Product instances, online store created
        Address address1 = new Address("123 Main St", "California", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Oak St", "New Brunswick", "NB", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", "ABC123", 2000.00, 2);
        Product product2 = new Product("Mouse", "XYZ789", 25.00, 5);

        Product product3 = new Product("Book", "DEF456", 8.00, 3);
        Product product4 = new Product("Headphones", "GHI789", 50.00, 1);

        // Creating Order instances
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product3, product4 }, customer2);

        // Displaying results
        Console.WriteLine("Order 1 Packing Label:\n" + order1._GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:\n" + order1._GetShippingLabel());
        Console.WriteLine("\nOrder 1 Total Price: $" + order1._CalculateTotalCost());

        Console.WriteLine("\n----------------------------------------\n");

        Console.WriteLine("Order 2 Packing Label:\n" + order2._GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:\n" + order2._GetShippingLabel());
        Console.WriteLine("\nOrder 2 Total Price: $" + order2._CalculateTotalCost());
    }
}