public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, Address theAddress)
    {
        _name = name;
        _address = theAddress;
    }
    public bool InUsa()
    {
        if (_address.GetCountry() == "USA")
        {
            return true;
        }
        else
            return false;

    }

    public string GetName()
    {
        return _name;
    }

    
    
}