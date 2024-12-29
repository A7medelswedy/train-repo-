using assignmentt.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace assignmentt.ViewModel
{

    public class OrderViewModel
    {
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<Customer> Customers { get; set; }

        public int ProductID { get; set; }
        public List<Product> Products { get; set; }
        public List<int> Quantities { get; set; } 
    }

  



}
