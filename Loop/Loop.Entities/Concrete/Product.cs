using Loop.Entities.Intermediate;
using System;
using System.Collections.Generic;

namespace Loop.Entities.Concrete
{
    public abstract class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserProduct> UserProducts { get; set; }
    }
}
