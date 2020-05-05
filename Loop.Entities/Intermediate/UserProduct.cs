using Loop.Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loop.Entities.Intermediate
{
    public class UserProduct
    {
        // ApplicationUser_Id begins with zero | not mapped
        [Key, Column(Order = 1)]
        public int ApplicationUser_Id { get; set; }

        [Key, Column(Order = 2)]
        public int ProductId { get; set; }

        [Required, Range(0, 1000000)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        // Check for time stamp | date time now
        [Required]
        [Display(Name = "Transaction Time")]
        public DateTime TransactionTime { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Product Product { get; set; }
    }
}
