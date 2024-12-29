using assignmentt.Models;

namespace assignmentt.ViewModel
{
    public class OrderDetailsViewModel
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<Product> Products { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }

}
