using Loop.Entities.Intermediate;
using System.Collections.Generic;


namespace Loop.Entities.Concrete
{
    public class Cart
    {
        public List<OrderProduct> OrderProducts { get; set; }

        public Cart()
        {
            OrderProducts = new List<OrderProduct>();
        }
    }
}
