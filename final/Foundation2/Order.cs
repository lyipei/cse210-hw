using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;

class Order
{
    private List<Product> _cart;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _cart = new List<Product>();
    }
    public void Additem(Product product)
    {
        _cart.Add(product);
    }
    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _cart)
        {
            total += product.GetTotalCost();
        }
        if (_customer.IsDomesticUSA())
        {
            total += 5;
        }
        else{
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _cart)
        {
            packingLabel += $"{product.GetName()} ({product.GetId()})\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
    
}