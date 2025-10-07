using System.Runtime.InteropServices.Marshalling;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;


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