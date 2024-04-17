namespace ASP6.ViewModels;

using System.Collections.Generic;

public class OrderDetailModel
{
    public int Quantity { get; set; }
    public List<ProductOrder> Products { get; set; }

    public OrderDetailModel()
    {
        Products = new List<ProductOrder>();
    }
}

public class ProductOrder
{
    public string Name { get; set; }
}