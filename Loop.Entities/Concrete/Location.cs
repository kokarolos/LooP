using System.ComponentModel.DataAnnotations;

namespace Loop.Entities.Concrete
{
    public class Location
    {
        [Required, Range(-90, 90)]
        [Display(Name = "Latitude")]
        public decimal? Latitude { get; set; }
        [Required, Range(-180, 180)]
        [Display(Name = "Longitude")]
        public decimal? Longitude { get; set; }
    }
}
