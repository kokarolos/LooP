using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Entities.Concrete
{
    public class Book : Product
    {
        [Required, MinLength(2), MaxLength(60)]
        [Display(Name = "Book Author")]
        public string BookAuthor { get; set; }

        [Required, MinLength(2), MaxLength(60)]
        [Display(Name = "Publisher")]
        public string Publisher { get; set; }

        [Range(0, 10000)]
        [Display(Name = "Number of pages")]
        public int Pages { get; set; }

        public virtual ImageFile  ImageFile { get; set; }
    }
}
