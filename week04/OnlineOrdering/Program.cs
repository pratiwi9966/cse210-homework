using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n================================================================");
        // 1. Create an address
        Address address1 = new Address("1234 Mountain Rd.", "Fruit Heights", "UT", "USA");

        // 2. Create an customer with the address
        Customer customer1 = new Customer("Weiling Sun", address1);

        // 3. Create some products
        Product product1 = new Product("Watercolor Paint Set", "ART001", 20.00, 2);
        Product product2 = new Product("Sketchbook (A4)", "ART002", 10.00, 4);

        // 4. Create an order for the customer
        Order order1 = new Order(customer1);

        // 5. Add products to the order
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // 6. Print the packing label 
        Console.WriteLine(order1.GetPackingLable());

        // 7. Print the shipping label
        Console.WriteLine(order1.GetShippingLabel());

        // 8. Print the total price
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice()}");
        
        Console.WriteLine("\n================================================================");

    }
}