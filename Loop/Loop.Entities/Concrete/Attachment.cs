using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Entities.Concrete
{
    public class Attachment
    {
        public int AttachmentId { get; set; }

        [Required, MinLength(2), MaxLength(300)]
        [Display(Name = "File Path")]

        public string Path { get; set; }
        public virtual Post Post { get; set; }

    }
}
