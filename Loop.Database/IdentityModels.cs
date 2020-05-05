using System.Data.Entity;
using Loop.Entities;
using Loop.Entities.Concrete;
using Loop.Entities.Intermediate;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Loop.Database
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserProduct> UserProducts { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<VideoFile> VideoFiles { get; set; }


        public object ApplicationUsers { get; set; }

        public ApplicationDbContext()
            : base("Connection", throwIfV1Schema: false)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}