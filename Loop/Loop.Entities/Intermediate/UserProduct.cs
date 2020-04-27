﻿using Loop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Entities.Intermediate
{
    public class UserProduct
    {
        // ApplicationUser_Id begins with zero | not mapped
        [Key, Column(Order = 1)]
        public int ApplicationUser_Id { get; set; }

        [Key, Column(Order = 2)]
        public int ProductId { get; set; }
        public decimal Price { get; set; }

        // Check for time stamp | date time now
        public DateTime TransactionTime { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Product Product { get; set; }
    }
}
