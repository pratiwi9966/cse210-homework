using System;
class Address
{
    // Member variables to store parts of the address
    private string _street;
    private string _city;
    private string _stateOrProvine;
    private string _country;

    //Constructor: set up the address
    public Address(string street, string city, string stateOrProvine, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvine = stateOrProvine;
        _country = country;
    }

    //Method 1: returns true if the country is USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa"; //Case-insensitive
    }

    // Method2: returns the full address 
    public string GetFullAddress()
    {
        // This returns the full address
        return $"{_street}\n{_city}, {_stateOrProvine}\n{_country}";
    }
}