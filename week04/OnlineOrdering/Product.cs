public class Product
{
    private string _name;
    private int _pricePerUnit;
    private int _quantity;
    private string _productId;


    public Product(string name, int price, int amount, string productId)
    {
        _name = name;
        _pricePerUnit = price;
        _quantity = amount;
        _productId = productId;
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

    public string GetProductId()
    {
        return _productId;
    }

}