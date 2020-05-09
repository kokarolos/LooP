using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text;
using Loop.Entities;
using Loop.Entities.Concrete;
using Loop.Entities.Intermediate;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Loop.Database
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserProduct> UserProducts { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<VideoFile> VideoFiles { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public ApplicationDbContext()
            : base("Connection" /*,throwIfV1Schema: false*/)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                        .Map<Tutorial>(m => m.Requires("ProductType").HasValue("Tutorial"))
                        .Map<Book>(m => m.Requires("ProductType").HasValue("Book"));
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //Catching seeding errors Method
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                ); // Add the original exception as the innerException
            }
        }
    }
}