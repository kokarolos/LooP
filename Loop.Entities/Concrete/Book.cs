using System.ComponentModel.DataAnnotations;


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
