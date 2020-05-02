using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
