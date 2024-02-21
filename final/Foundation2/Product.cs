class Product
{
    public string Name { get; set; }
    public int ProductID { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }
}
