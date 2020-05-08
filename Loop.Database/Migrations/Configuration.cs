namespace Loop.Database.Migrations
{
    using Loop.Entities;
    using Loop.Entities.Concrete;
    using Loop.Entities.Intermediate;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;


    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            #region Seeding 

            // *** ~~~ ~~~ ~~~ *** Locations *** ~~~ ~~~ ~~~ ***
            Location loc1 = new Location() { Latitude = 40.63342m, Longitude = 22.94188m };
            Location loc2 = new Location() { Latitude = 35.51421m, Longitude = 24.02157m };
            Location loc3 = new Location() { Latitude = 37.98406m, Longitude = 23.72602m };
            Location loc4 = new Location() { Latitude = 35.50667m, Longitude = 27.21009m };
            Location loc5 = new Location() { Latitude = 37.94477m, Longitude = 23.64358m };

            // *** ~~~ ~~~ ~~~ *** Users *** ~~~ ~~~ ~~~ ***
            ApplicationUser a1 = new ApplicationUser() { FirstName = "Maria", LastName = "Kalimeri", DateOfBirth = new DateTime(1993, 05, 27), UserName = "mkalimeri93", Location = loc1 };
            ApplicationUser a2 = new ApplicationUser() { FirstName = "Nikolaos", LastName = "Koromilakis", DateOfBirth = new DateTime(1980, 09, 18), UserName = "nkoromilakis80", Location = loc2 };
            ApplicationUser a3 = new ApplicationUser() { FirstName = "Konstantinos", LastName = "Peponakis", DateOfBirth = new DateTime(2001, 07, 23), UserName = "kpeponakis01", Location = loc3 };
            ApplicationUser a4 = new ApplicationUser() { FirstName = "Anna", LastName = "Karpouzaki", DateOfBirth = new DateTime(1996, 01, 31), UserName = "akarpouzaki96", Location = loc4 };
            ApplicationUser a5 = new ApplicationUser() { FirstName = "Pinelopi", LastName = "Portokalaki", DateOfBirth = new DateTime(1998, 05, 16), UserName = "pportokalaki98", Location = loc5 };

            // *** ~~~ ~~~ ~~~ *** Tags *** ~~~ ~~~ ~~~ ***
            Tag tg1 = new Tag() { Title = "C#", Description = "C# is a modern all purpose programming language." };
            Tag tg2 = new Tag() { Title = "Javascript", Description = "Javascript is the de facto language of front end development." };
            Tag tg3 = new Tag() { Title = "Basic", Description = "Once a very popular first language." };
            Tag tg4 = new Tag() { Title = "C", Description = "C is a very fast and close to the system language." };
            Tag tg5 = new Tag() { Title = "C++", Description = "C++ added classes to the C language." };
            Tag tg6 = new Tag() { Title = "HTML", Description = "Hyper text markup language\'s main application is constructing web sites." };

            // *** ~~~ ~~~ ~~~ *** Posts *** ~~~ ~~~ ~~~ ***
            Post p1 = new Post() { Title = "Printing a string", Text = "I want to print a string multiple times at the console using C#", DateTime = new DateTime(2019, 06, 18, 7, 0, 0) };
            Post p2 = new Post() { Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0) };

            // *** ~~~ ~~~ ~~~ *** Replies *** ~~~ ~~~ ~~~ ***
            Reply r1 = new Reply() { Text = "Use the Console.WriteLine function", DateTime = new DateTime(2019, 06, 18, 7, 15, 0) };
            Reply r2 = new Reply() { Text = "Use the for statement combined with Console.WriteLine", DateTime = new DateTime(2019, 06, 18, 7, 30, 0) };
            Reply r3 = new Reply() { Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r4 = new Reply() { Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r5 = new Reply() { Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            // *** ~~~ ~~~ ~~~ *** Tags Per Post *** ~~~ ~~~ ~~~ ***
            p1.Tags = new List<Tag>() { tg1 };
            p2.Tags = new List<Tag>() { tg2, tg6 };

            // *** ~~~ ~~~ ~~~ *** Replies Per Post *** ~~~ ~~~ ~~~ ***
            p1.Replies = new List<Reply>() { r1, r2 };
            p2.Replies = new List<Reply>() { r3, r4, r5 };

            // *** ~~~ ~~~ ~~~ *** Posts Per User *** ~~~ ~~~ ~~~ ***
            a1.Posts = new List<Post>() { p1 };
            a3.Posts = new List<Post>() { p2 };

            // *** ~~~ ~~~ ~~~ *** Replies Per User *** ~~~ ~~~ ~~~ ***
            a1.Replies = new List<Reply>() { r3 };
            a2.Replies = new List<Reply>() { r1 };
            a4.Replies = new List<Reply>() { r4 };
            a5.Replies = new List<Reply>() { r2, r5 };


            // *** ~~~ ~~~ ~~~ *** Books *** ~~~ ~~~ ~~~ ***
            Book b1 = new Book() { BookAuthor = "Peter Rich", Title = "Programming with C", Description = "An whole new approach to the C programming", Publisher = "Random Books", Pages = 133, DateTime = new DateTime(2001, 04, 09) };
            Book b2 = new Book() { BookAuthor = "Olga Moskovskaya", Title = "The windows GUI", Description = "This is an introduction of the windows OS GUI", Publisher = "Little House", Pages = 300, DateTime = new DateTime(2008, 07, 25) };
            Book b3 = new Book() { BookAuthor = "Anna Petersson", Title = "History of Computing", Description = "The events that marked the rise of computing era", Publisher = "Random Books", Pages = 500, DateTime = new DateTime(2017, 04, 18) };
            Book b4 = new Book() { BookAuthor = "John Stone", Title = "The Linux OS", Description = "A deep understanding of a popular OS", Publisher = "Bird House", Pages = 100, DateTime = new DateTime(2016, 01, 31) };
            Book b5 = new Book() { BookAuthor = "Alice Booker", Title = "Basic Cryptography", Description = "An introduction to basic principles of cryptography", Publisher = "Hidden Books", Pages = 150, DateTime = new DateTime(2012, 02, 29) };

            // *** ~~~ ~~~ ~~~ *** Tutorials *** ~~~ ~~~ ~~~ ***
            Tutorial tu1 = new Tutorial() { TutorialAuthor = "Dr. Hans Stroke", Title = "Learn C++", Description = "An all around approach to the C++ programming language.", Duration = TimeSpan.FromMinutes(120), DateTime = new DateTime(2004, 06, 02) };
            Tutorial tu2 = new Tutorial() { TutorialAuthor = "John Fields", Title = "Advanced C#", Description = "Advanced topics of the C# programming, like delegates, generics and pointer handling.", Duration = TimeSpan.FromMinutes(140), DateTime = new DateTime(2017, 01, 23) };
            Tutorial tu3 = new Tutorial() { TutorialAuthor = "Mary Green", Title = "Beginner\'s C#", Description = "An introduction to the C#, including variables, classes and methods.", Duration = TimeSpan.FromMinutes(110), DateTime = new DateTime(2013, 01, 12) };
            Tutorial tu4 = new Tutorial() { TutorialAuthor = "Steven Orange", Title = "Absolute C Tutorial", Description = "This is a tutorial of C programming, with emphasis on low level techniques.", Duration = TimeSpan.FromMinutes(90), DateTime = new DateTime(2009, 07, 17) };
            Tutorial tu5 = new Tutorial() { TutorialAuthor = "Bill Windows", Title = "Python for Beginners", Description = "Learn Python, an exceptional choice for introduction to programming.", Duration = TimeSpan.FromMinutes(60), DateTime = new DateTime(2015, 03, 01) };

            // *** ~~~ ~~~ ~~~ *** UserProducts (Per UserID) *** ~~~ ~~~ ~~~ ***
            UserProduct up1 = new UserProduct() { ApplicationUser_Id = a1.Id, TransactionTime = new DateTime(2020, 1, 1), Price = 10m };
            UserProduct up2 = new UserProduct() { ApplicationUser_Id = a2.Id, TransactionTime = new DateTime(2019, 11, 14), Price = 9.95m };
            UserProduct up3 = new UserProduct() { ApplicationUser_Id = a2.Id, TransactionTime = new DateTime(2019, 12, 3), Price = 14.95m };
            UserProduct up4 = new UserProduct() { ApplicationUser_Id = a3.Id, TransactionTime = new DateTime(2019, 12, 5), Price = 14.45m };
            UserProduct up5 = new UserProduct() { ApplicationUser_Id = a4.Id, TransactionTime = new DateTime(2019, 12, 9), Price = 14.95m };
            UserProduct up6 = new UserProduct() { ApplicationUser_Id = a4.Id, TransactionTime = new DateTime(2019, 12, 10), Price = 19.9m };
            UserProduct up7 = new UserProduct() { ApplicationUser_Id = a4.Id, TransactionTime = new DateTime(2019, 12, 11), Price = 5.95m };

            // *** ~~~ ~~~ ~~~ *** UserProducts Per Product *** ~~~ ~~~ ~~~ ***
            b1.UserProducts = new List<UserProduct> { up1 };
            b2.UserProducts = new List<UserProduct> { up3, up4, up5 };
            b3.UserProducts = new List<UserProduct> { up6 };
            tu1.UserProducts = new List<UserProduct> { up2 };
            tu5.UserProducts = new List<UserProduct> { up7 };

            // *** ~~~ ~~~ ~~~ *** Video Files *** ~~~ ~~~ ~~~ ***
            VideoFile v1 = new VideoFile() { Vname = "NightStalker", Vpath = "~/VideoFiles/NIGHTSTALKER - Sweet Knife (HD Official Music Video).mp4" };

            // *** ~~~ ~~~ ~~~ *** Image Files *** ~~~ ~~~ ~~~ ***
            ImageFile img1 = new ImageFile() { ImgName = "Schema", ImgPath = "~/ImageFiles/σχημα.PNG" };


            context.Users.AddOrUpdate(x => x.UserName, a1, a2, a3, a4, a5);
            context.Tags.AddOrUpdate(x => x.Title, tg1, tg2, tg3, tg4, tg5, tg6);
            context.Products.AddOrUpdate(x => x.Title, tu1, tu2, tu3, tu4, tu5, b1, b2, b3, b4, b5);
            context.VideoFiles.AddOrUpdate(x => x.Vname, v1);
            context.ImageFiles.AddOrUpdate(x => x.ImgName, img1);
            context.SaveChanges();
            #endregion
        }
    }
}
