using System;

class Product
{
    // These are the variables to store product details
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor: It sets the values when we create a new product.
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // method1 : to calculates and returns the total cost
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    //method2 : to prints out the product information
    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product Name: {_name}");
        Console.WriteLine($"Product ID: {_productId}");
        Console.WriteLine($"Price per item: ${_price}");
        Console.WriteLine($"Total Cost: ${GetTotalCost()}");
    }

    // Method 3: Get the product name (Getter method)
    public string GetName()
    {
        return _name;
    }

    // Method 4: Get the product ID
    public string GetProductId()
    {
        return _productId;
    }

    // Method 5: Get quantity 
    public int GetQuantity()
    {
        return _quantity;
    }

}