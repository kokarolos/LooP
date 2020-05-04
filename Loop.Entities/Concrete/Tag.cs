using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Loop.Entities
{
    public class Tag
    {
        public int TagId { get; set; }

        [Required, MinLength(1), MaxLength(60)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required, MinLength(10), MaxLength(300)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
