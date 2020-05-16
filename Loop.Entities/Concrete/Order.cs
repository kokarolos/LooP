using System;
using Loop.Entities.Intermediate;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loop.Entities.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
