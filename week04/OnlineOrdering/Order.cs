using System;

using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize the order
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate the total price including shipping
    public double GetTotalPrice()
    {
        double total = 0;

        //Add cost for each product
        foreach (Product product in _products)
        {
            total += product.GetTotalCost(); //price * quantity
        }

        // Add shipping cost
        if (_customer.LivesInUSA())
        {
            total += 5.00;
        }
        else
        {
            total += 35.00;
        }

        return total;
    }

    // Creat packing label: list of name and product ID
    public string GetPackingLable()
    {
        // Start with a title for the packing label
        string label = "\nPacking Label: \n";

        // Go through each product in the list
        foreach (Product product in _products)
        {
            // Get the product name and ID
           // string name = product.GetName();
           // string id = product.GetProductId();

            // Add product info to the label, each on a new line
            //label = label + "- " + name + " (ID: " + id + ")\n";

            label += $"-{product.GetName()} (ID: {product.GetProductId()}) - Quantity: {product.GetQuantity()}\n";
        }
        // Return the full label string
        return label;
    }

    // Creat shipping label: customer name and address
    public string GetShippingLabel()
    {
        string label = "Shipping Label: \n"; // Start with a title
        label += _customer.GetName() + "\n"; // Get the customer's name
        label += _customer.GetAddress().GetFullAddress(); // Add full address from Address class

        return label; // Return the full label
    }



}

