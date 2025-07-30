using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n================================================================");

        // -------- ORDER 1 --------
        // 1. Create an address and an customer with the address
        Address address1 = new Address("1234 Mountain Rd.", "Fruit Heights", "UT", "USA");
        Customer customer1 = new Customer("Weiling Sun", address1);

        // 2. Create some products
        Product product1 = new Product("Watercolor Paint Set", "ART001", 20.00, 2);
        Product product2 = new Product("Sketchbook (A4)", "ART002", 10.00, 4);

        // 3. Create an order for the customer
        Order order1 = new Order(customer1);

        // 4. Add products to the order
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // 5. Print the packing label 
        Console.WriteLine(order1.GetPackingLable());

        // 6. Print the shipping label
        Console.WriteLine(order1.GetShippingLabel());

        // 7. Print the total price
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice()}");

        Console.WriteLine("\n================================================================");


        // -------- ORDER 2 --------
        // 1. Create an address and an customer with the address
        Address address2 = new Address("5678 Mountain Rd.", "Fruit Height", "ON", "Canada");
        Customer customer2 = new Customer("Steven Stromberg", address2);

        // 2. Create some products
        Product product3 = new Product("Acrylic Paint Set", "ART101", 25.00, 2);
        Product product4 = new Product("Canvas Bord (8x10)", "ART102", 15.50, 5);

        // 3. Create an order for the customer
        Order order2 = new Order(customer2);

        // 4. Add products to the order
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // 5.Print the packing label 
        Console.WriteLine(order2.GetPackingLable());
        // 6. Print the shipping label
        Console.WriteLine(order2.GetShippingLabel());
        // 7. Print the total price
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice()}");

        Console.WriteLine("\n================================================================");


    }
}