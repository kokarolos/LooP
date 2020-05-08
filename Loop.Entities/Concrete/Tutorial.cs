using System;
using System.ComponentModel.DataAnnotations;

namespace Loop.Entities.Concrete
{
    public class Tutorial : Product
    {
        [Required, MinLength(2), MaxLength(60)]
        [Display(Name = "Tutorial Author")]
        public string TutorialAuthor { get; set; }

        [Display(Name = "Duration")]
        public TimeSpan Duration { get; set; }


        public virtual VideoFile  VideoFile { get; set; }
    }
}
