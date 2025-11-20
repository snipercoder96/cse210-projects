/* Final boss */

class Order
{
    private List<Product> _products; // list 
    private Customer _customer; // 

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;

    }

    public double TotalCost()
    {
        double totalProduct = 0;

        for (int i = 0; i < _products.Count; i++)
        {

            totalProduct += _products[i].GetTotalCost();
        }

        int shippingCost;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5;
        }

        else
        {
            shippingCost = 35;
        }

        return totalProduct + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        for (int i = 0; i < _products.Count; i++) // loop through and then add 
        {
            label += $"Product: {_products[i].SetName()} — ID: {_products[i].SetProductID()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
      
        string label = "Shipping Label:\n";
        label += $"{_customer.SetName()}\n";
        label += _customer.SetAddress().DisplayAddress();
        return label;
    }
}