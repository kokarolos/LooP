namespace Loop.Database.Migrations
{
    using Loop.Entities;
    using Loop.Entities.Concrete;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            Post p = new Post() { Text = "mlmml" };
            Post p2 = new Post() { Text = "newPost" };
            ApplicationUser a1 = new ApplicationUser() { Age = 23, UserName = "Nick" };

            a1.Posts = new List<Post> { p,p2 };
            context.Posts.AddOrUpdate(x => x.Text, p, p2);
            context.Users.AddOrUpdate(x => x.UserName, a1);
            context.SaveChanges();

        }
    }
}
