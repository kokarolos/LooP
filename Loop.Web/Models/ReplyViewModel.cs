using Loop.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Loop.Web.Models
{
    public class ReplyViewModel
    {
        public int ReplyId { get; set; }
        public int PostId { get; set; }

        [Required, MinLength(10), MaxLength(5000)]
        [Display(Name = "Reply Text")]
        public string Text { get; set; }

        [Required]
        [Display(Name = "Date and Time of Replying")]
        public DateTime PostDate { get; set; }

        public Post CurrentPost { get; set; }



        //[Required]
        //public virtual ApplicationUser ApplicationUser { get; set; }
        //public virtual Post Post { get; set; }
    }
}