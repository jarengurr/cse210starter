using System.Runtime.InteropServices.Marshalling;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAllInfo()
    {
        _street = "780 W. Capitan Street";
        _city = "West Hamstring";
        _state = "California";
        _country = "USA";

        string holdString;
        holdString = $"{_street} {Environment.NewLine}{_city} {_state} {_country}";

        return holdString;
    }

    public string GetCountry()
    {
        return _country;
    }


}