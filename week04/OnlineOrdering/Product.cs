public class Product
{
    private string _name;
    private int _pricePerUnit;
    private int _quantity;


    public Product(string name, int price, int amount)
    {
        _name = name;
        _pricePerUnit = price;
        _quantity = amount;
    }

    public int GetPrice()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public string GetName()
    {
        return _name;
    }

}