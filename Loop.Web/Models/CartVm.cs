using Loop.Entities.Concrete;
using Loop.Entities.Intermediate;
using System.Collections.Generic;


namespace Loop.Web.Models
{
    public class CartVm
    {
        public List<Product> Products { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

        public CartVm()
        {
            Products = new List<Product>();
            OrderProducts = new List<OrderProduct>();
        }
    }
}