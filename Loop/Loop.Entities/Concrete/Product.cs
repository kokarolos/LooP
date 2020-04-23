using System;
using System.Collections.Generic;

namespace Loop.Entities.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }


    }
}
