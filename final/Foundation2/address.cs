using System;
using System.Collections.Generic;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateProvince = stateProvince;
        this._country = country;
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}