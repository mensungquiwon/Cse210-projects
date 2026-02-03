using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country )
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public bool IsInUSA()
    {
        if (_country == "USA" || _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}, {_country}";
    }
}