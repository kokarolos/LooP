using Loop.Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loop.Entities.Intermediate
{
    public class UserProduct
    {

        [Key, Column(Order = 1)]
        public string ApplicationUserId { get; set; }

        [Key, Column(Order = 2)]
        public int ProductId { get; set; }

        [Required, Range(0, 1000000)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Transaction Time")]
        public DateTime TransactionTime { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Product Product { get; set; }
    }
}
