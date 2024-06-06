class Order
{
    private List<Product> _products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this._products = products;
        this.customer = customer;
    }
    // Calculating total cost of the order
    public double _CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product._GetTotalCost();
        }

        // Add shipping cost based on customer location
        totalCost += customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string _GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"{product._GetName()} - {product._GetProductId()}\n";
        }
        return packingLabel;
    }

    public string _GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}