class Customer

// Create Customer class
// Add constructor to the Customer class
// Add Name property to the Customer class
// Add Address property to the Customer class
// Add IsInUSA method to the Customer class
// Add GetName method to the Customer class
// Add GetAddress method to the Customer class
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}