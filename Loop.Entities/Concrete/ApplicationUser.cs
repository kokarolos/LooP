using Loop.Entities.Intermediate;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Loop.Entities.Concrete
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        [MinLength(2), MaxLength(60)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MinLength(2), MaxLength(60)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarPath { get; set; }

        //[Display(Name = "Location")]
        //public virtual Location Location { get; set; }

        [NotMapped]
        public int Age
        {
            get
            {
                if(!DateOfBirth.HasValue)
                {
                    return 0;
                }
                else
                {
                    return DateTime.Now.Year - DateOfBirth.Value.Year;
                }
                
            }

        }

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
        public virtual ICollection<UserProduct> UserProducts { get; set; }
    }
}
