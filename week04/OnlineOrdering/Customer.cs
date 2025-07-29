using System;

class Customer
{
    //Member variables to store the name and address
    private string _name;
    private Address _address;
    // _address is not just a string — it's an object of the Address class.
    // This customer has an address, and that address is an object that holds all the details.

    // string _name is like writing their name on a sticky note.
    // Address _address is like putting their whole address (with multiple lines) inside a folder.

    // Constructor to initialize name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method 1: to return the customer's name (as an Address object)
    public Address GetAddress()
    {
        return _address;
    }

    // Method 2: to return the customer's name
    public string GetName()
    {
        return _name;
    }

    // Method 3: Checks if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA(); // This calls the method from Address class
    }

}