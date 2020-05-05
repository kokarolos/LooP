using System.ComponentModel.DataAnnotations;

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
