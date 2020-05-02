namespace Loop.Database.Migrations
{
    using Loop.Entities;
    using Loop.Entities.Concrete;
    using Loop.Entities.Intermediate;
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
            #region Seeding
            Post p1 = new Post() { Text = "Post One" };
            Post p2 = new Post() { Text = "Post Two" };
            Post p3 = new Post() { Text = "Post Three" };
            Post p4 = new Post() { Text = "Post Four" };
            Post p5 = new Post() { Text = "Post Five" };

            ApplicationUser a1 = new ApplicationUser() { DateOfBirth = new DateTime(1993, 05, 07), UserName = "Nick" };
            ApplicationUser a2 = new ApplicationUser() { DateOfBirth = new DateTime(1993, 05, 09), UserName = "Panos" };
            ApplicationUser a3 = new ApplicationUser() { DateOfBirth = new DateTime(1990, 06, 07), UserName = "Giannis" };
            ApplicationUser a4 = new ApplicationUser() { DateOfBirth = new DateTime(1983, 06, 07), UserName = "Thanos" };
            ApplicationUser a5 = new ApplicationUser() { DateOfBirth = new DateTime(1973, 05, 04), UserName = "Karolos" };

            Tutorial t1 = new Tutorial() { Title = "Tutorial One", Duration = 120 };
            Tutorial t2 = new Tutorial() { Title = "Tutorial Two", Duration = 140 };
            Tutorial t3 = new Tutorial() { Title = "Tutorial Three", Duration = 160 };
            Tutorial t4 = new Tutorial() { Title = "Tutorial Four", Duration = 90 };
            Tutorial t5 = new Tutorial() { Title = "Tutorial Five", Duration = 60 };

            Book b1 = new Book() { Title = "Book One", Description = "Novel", Author = "Author One", Pages = 300 };
            Book b2 = new Book() { Title = "Book Two", Description = "Novel", Author = "Author Two", Pages = 600 };
            Book b3 = new Book() { Title = "Book Three", Description = "Novel", Author = "Author Three", Pages = 500 };
            Book b4 = new Book() { Title = "Book Four", Description = "Novel", Author = "Author Four", Pages = 100 };
            Book b5 = new Book() { Title = "Book Five", Description = "Novel", Author = "Author Five", Pages = 150 };

            UserProduct up1 = new UserProduct() { ApplicationUser = a1, Product = b1, TransactionTime = new DateTime(2020, 1, 1), Price = 100 };

            VideoFile v1 = new VideoFile() { Vname = "NightStalker", Vpath = "~/VideoFiles/NIGHTSTALKER - Sweet Knife (HD Official Music Video).mp4" };
            ImageFile img1 = new ImageFile() { ImgName = "Schema", ImgPath = "~/ImageFiles/σχημα.PNG" };


            a1.Posts = new List<Post> { p1, p2 };
            a2.Posts = new List<Post> { p3, p4 };
            a3.Posts = new List<Post> { p5 };


            context.Posts.AddOrUpdate(x => x.Text, p1, p2, p2, p3, p4, p5);
            context.VideoFiles.AddOrUpdate(x => x.Vname, v1);
            context.ImageFiles.AddOrUpdate(x => x.ImgName, img1);
            context.Users.AddOrUpdate(x => x.UserName, a1, a2, a3, a4, a5);
            context.Products.AddOrUpdate(x => x.Title, t1, t2, t3, t4, t5, b1, b2, b3, b4, b5);
            context.UserProducts.AddOrUpdate(x => x.TransactionTime, up1);
            context.SaveChanges();
            #endregion
        }
    }
}
