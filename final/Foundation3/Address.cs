public class Address
{
    // TODO: Add properties to the Address class
    public string _Street {get;}
    public string _City {get;}
    public string _State {get;}
    public string _ZipCode {get;}

    // TODO: Add constructor to the Address class
    public Address(string street, string city, string state, string zipCode)
    {
        _Street = street;
        _City = city;
        _State = state;
        _ZipCode = zipCode;
    }
}