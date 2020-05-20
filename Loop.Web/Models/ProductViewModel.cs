using System;
using System.ComponentModel.DataAnnotations;


namespace Loop.Web.Models
{
    public class ProductViewModel 
    {
        public int ProductId { get; set; }

        [MinLength(2), MaxLength(60)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [ MinLength(10), MaxLength(300)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        
        [Display(Name = "Date and Time of Production")]
        public DateTime? ProductionDate { get; set; }

        [MinLength(2), MaxLength(60)]
        [Display(Name = "Book Author")]
        public string BookAuthor { get; set; }

        [MinLength(2), MaxLength(60)]
        [Display(Name = "Publisher")]
        public string Publisher { get; set; }

        [Range(0, 10000)]
        [Display(Name = "Number of pages")]
        public int Pages { get; set; }


        [MinLength(2), MaxLength(60)]
        [Display(Name = "Tutorial Author")]
        public string TutorialAuthor { get; set; }

        [Display(Name = "Duration")]
        public TimeSpan? Duration { get; set; }

        public string PhotoUrl { get; set; }

        //public virtual Image ImageFile { get; set; }
        //public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}