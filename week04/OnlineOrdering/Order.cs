public class Order
{
    private List<Product> _myProduct = new List<Product>();
    private Customer _theCustomer;
    private int _totalCost;

    private const int _usa = 15;
    private const int _nonUsa = 35;

    public Order(Customer theCustomer)
    {
        _theCustomer = theCustomer;
    }


    public string PackLabel()
    {
        return "";
    }

    public string ShipLabel()
    {
        return "";
    }

    public void AddProduct(Product newProduct)
    {
        _myProduct.Add(newProduct);
    }

    public void AddCosts()
    {



        for (int i = 0; i < _myProduct.Count; i++)
        {

            _totalCost = _totalCost + (_myProduct[i].GetPrice() * _myProduct[i].GetQuantity());

        }
    }

    public void SetCustomer(Customer bestCustomer)
    {
        _theCustomer = bestCustomer;
    }

}