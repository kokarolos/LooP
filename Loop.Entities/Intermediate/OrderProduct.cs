using Loop.Entities.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loop.Entities.Intermediate
{
    public class OrderProduct
    {

        [Key, Column(Order = 1)]
        public int OrderId { get; set; }

        [Key, Column(Order = 2)]
        public int ProductId { get; set; }

        [Required, Range(0, 1000000)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required,Range(0,100)]
        public int Quantity { get; set; }
        public int Dummy { get; set; }


        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
