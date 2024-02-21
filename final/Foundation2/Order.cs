class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.GetTotalCost();
        }

        double shippingCost = Customer.IsInUSA() ? 5 : 35;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"Product: {product.Name}, Product ID: {product.ProductID}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"Customer Name: {Customer.Name}\n";
        label += Customer.Address.GetAddressDetails();
        return label;
    }
}
