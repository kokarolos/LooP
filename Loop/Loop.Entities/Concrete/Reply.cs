using Loop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Loop.Entities
{
    //TODO: Implement Datetime property as Reply Creation Datetime
    public class Reply
    {
        public int ReplyId { get; set; }

        [Required, MinLength(10), MaxLength(5000)]
        [Display(Name = "Reply Text")]
        public string Text { get; set; }

        [Required]
        [Display(Name = "Date and Time of Replying")]
        public DateTime DateTime { get; set; }

        public int? PostId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Post Post { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
