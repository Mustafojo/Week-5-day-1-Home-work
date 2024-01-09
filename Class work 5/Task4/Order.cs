public class Order
{
    public int OrderNumber;
    public string ProductName;
    public int Quantity;
    public decimal TotalAmount;
    public Order(int orderNumber,string productName,int quantity,decimal toTalamount)
    {
        this.OrderNumber = orderNumber;
        this.ProductName = productName;
        this.Quantity = quantity;
        this.TotalAmount = toTalamount;
    }
    public Order(string productName,int  productQuantity )
    {
        this.ProductName = productName;
        this.Quantity = productQuantity;
    }
     public Order(string productName,decimal totalAmount )
    {
        this.ProductName = productName;
        this.TotalAmount = totalAmount;
    }
}