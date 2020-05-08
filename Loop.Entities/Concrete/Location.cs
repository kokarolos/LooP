<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using System.ComponentModel.DataAnnotations;
>>>>>>> Rebase Conflicts Try

namespace Loop.Entities.Concrete
{
    public class Location
    {
        [Required, Range(-90, 90)]
        [Display(Name = "Latitude")]
<<<<<<< HEAD
        public decimal Latitude { get; set; }
        [Required, Range(-180, 180)]
        [Display(Name = "Longitude")]
        public decimal Longitude { get; set; }
    }
}
=======
        public decimal? Latitude { get; set; }
        [Required, Range(-180, 180)]
        [Display(Name = "Longitude")]
        public decimal? Longitude { get; set; }
    }
}
>>>>>>> Rebase Conflicts Try
