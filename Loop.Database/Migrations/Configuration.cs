namespace Loop.Database.Migrations
{
    using Loop.Entities;
    using Loop.Entities.Concrete;
    using Loop.Entities.Intermediate;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            #region Seeding 
            var userManager1 = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // *** ~~~ ~~~ ~~~ *** Roles  *** ~~~ ~~~ ~~~ *** 

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };

                manager.Create(role);

            }

            if (!context.Roles.Any(r => r.Name == "User"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "User" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Customer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Customer" };
                manager.Create(role);
            }


            // *** ~~~ ~~~ ~~~ *** User Customer Admins  *** ~~~ ~~~ ~~~ *** 

            if (!context.Users.Any(user => user.UserName == "admin1@gmail.com"))
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var passwordHash = new PasswordHasher();

                var user = new ApplicationUser
                {
                    UserName = "karolos",
                    Email = "admin1@gmail.com",
                    DateOfBirth = new DateTime(1994, 1, 1),
                    PasswordHash = passwordHash.HashPassword("Admin123!"),
                    FirstName = "Karolos",
                    LastName = "Koniewicz",
                };

                userManager.Create(user);
                userManager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(user => user.UserName == "admin2@gmail.com"))
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var passwordHash = new PasswordHasher();

                var user = new ApplicationUser
                {
                    UserName = "Rizai",
                    Email = "admin2@gmail.com",
                    DateOfBirth = new DateTime(1994, 1, 1),
                    PasswordHash = passwordHash.HashPassword("Admin123!"),
                    FirstName = "Panos",
                    LastName = "Rizos",
                };
                userManager.Create(user);
                userManager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(user => user.UserName == "admin3@gmail.com"))
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var passwordHash = new PasswordHasher();

                var user = new ApplicationUser
                {
                    UserName = "KatrakisMan",
                    Email = "admin3@gmail.com",
                    DateOfBirth = new DateTime(1994, 1, 1),
                    PasswordHash = passwordHash.HashPassword("Admin123!"),
                    FirstName = "Thanos",
                    LastName = "Katrakis",
                };
                userManager.Create(user);
                userManager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(user => user.UserName == "admin4@gmail.com"))
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var passwordHash = new PasswordHasher();

                var user = new ApplicationUser
                {
                    UserName = "ManthosIoannis",
                    Email = "admin4@gmail.com",
                    DateOfBirth = new DateTime(1994, 1, 1),
                    PasswordHash = passwordHash.HashPassword("Admin123!"),
                    FirstName = "Ioannis",
                    LastName = "Manos",

                };
                userManager.Create(user);
                userManager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(user => user.UserName == "customergmail.com"))
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var passwordHash = new PasswordHasher();

                var user = new ApplicationUser
                {
                    UserName = "Customer",
                    Email = "customer@gmail.com",
                    DateOfBirth = new DateTime(1994, 1, 1),
                    PasswordHash = passwordHash.HashPassword("Admin123!"),
                    FirstName = "Customer",
                    LastName = "Dear",

                };
                userManager.Create(user);
                userManager.AddToRole(user.Id, "Customer");
            }

            if (!context.Users.Any(user => user.UserName == "user@gmail.com"))
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var passwordHash = new PasswordHasher();

                var user = new ApplicationUser
                {
                    UserName = "user",
                    Email = "user@gmail.com",
                    DateOfBirth = new DateTime(1994, 1, 1),
                    PasswordHash = passwordHash.HashPassword("Admin123!"),
                    FirstName = "Karolos",
                    LastName = "Koniewicz",
                };

                userManager.Create(user);
                userManager.AddToRole(user.Id, "User");
            }

            // *** ~~~ ~~~ ~~~ *** Users *** ~~~ ~~~ ~~~ *** 

            ApplicationUser a1 = new ApplicationUser() { FirstName = "Maria", LastName = "Kara", DateOfBirth = new DateTime(1993, 05, 27), UserName = "KaMaryRa" };
            ApplicationUser a2 = new ApplicationUser() { FirstName = "John", LastName = "Brown", DateOfBirth = new DateTime(1980, 09, 18), UserName = "JohnTheBrown" };
            ApplicationUser a3 = new ApplicationUser() { FirstName = "Konstantinos", LastName = "Petrou", DateOfBirth = new DateTime(2001, 07, 23), UserName = "PetrouKo" };
            ApplicationUser a4 = new ApplicationUser() { FirstName = "Anna", LastName = "Lamprou", DateOfBirth = new DateTime(1999, 01, 31), UserName = "annnLamp" };
            ApplicationUser a5 = new ApplicationUser() { FirstName = "Pinelopi", LastName = "Ioannou", DateOfBirth = new DateTime(1994, 05, 16), UserName = "TheCoder" };
            ApplicationUser a6 = new ApplicationUser() { FirstName = "John", LastName = "Papadopoulos", DateOfBirth = new DateTime(1991, 04, 16), UserName = "pap19!" };
            ApplicationUser a7 = new ApplicationUser() { FirstName = "Costas", LastName = "Ioannou", DateOfBirth = new DateTime(1999, 03, 16), UserName = "Ioannou93!" };
            ApplicationUser a8 = new ApplicationUser() { FirstName = "Karol", LastName = "Koniewic", DateOfBirth = new DateTime(1994, 02, 16), UserName = "Kokarol94!" };
            ApplicationUser a9 = new ApplicationUser() { FirstName = "Helen", LastName = "Petrou", DateOfBirth = new DateTime(1974, 02, 16), UserName = "PetPet22!" };
            ApplicationUser a10 = new ApplicationUser() { FirstName = "Maria", LastName = "Dimitropoulou", DateOfBirth = new DateTime(1998, 02, 15), UserName = "Dimm98!" };
            ApplicationUser a11 = new ApplicationUser() { FirstName = "Gianna", LastName = "Pavlou", DateOfBirth = new DateTime(1975, 03, 17), UserName = "Pavlou17!" };
            ApplicationUser a12 = new ApplicationUser() { FirstName = "Ilias", LastName = "Pappas", DateOfBirth = new DateTime(1998, 04, 20), UserName = "IlPap20!" };
            ApplicationUser a13 = new ApplicationUser() { FirstName = "Charis", LastName = "Kollias", DateOfBirth = new DateTime(1994, 10, 07), UserName = "KolliasChar!" };
            ApplicationUser a14 = new ApplicationUser() { FirstName = "Dwra", LastName = "Charitou", DateOfBirth = new DateTime(1991, 03, 18), UserName = "DwraCharitou18!" };
            ApplicationUser a15 = new ApplicationUser() { FirstName = "Dimitra", LastName = "Rizou", DateOfBirth = new DateTime(1991, 02, 16), UserName = "RizouDim16!" };
            ApplicationUser a16 = new ApplicationUser() { FirstName = "Kostas", LastName = "Kostopoulos", DateOfBirth = new DateTime(1992, 02, 16), UserName = "Kostoko16!" };
            ApplicationUser a17 = new ApplicationUser() { FirstName = "Ioannis", LastName = "Dimitriou", DateOfBirth = new DateTime(1994, 02, 17), UserName = "IoDim17!" };
            ApplicationUser a18 = new ApplicationUser() { FirstName = "Thanos", LastName = "Petrou", DateOfBirth = new DateTime(1996, 02, 12), UserName = "ThanosPetrou12!" };
            ApplicationUser a19 = new ApplicationUser() { FirstName = "Panos", LastName = "Ioannou", DateOfBirth = new DateTime(1994, 02, 16), UserName = "PanIoannou16!" };
            ApplicationUser a20 = new ApplicationUser() { FirstName = "Nikos", LastName = "Giannakopoulos", DateOfBirth = new DateTime(1994, 02, 16), UserName = "Giann16!" };
            ApplicationUser a21 = new ApplicationUser() { FirstName = "Tom", LastName = "Spacer", DateOfBirth = new DateTime(1979, 01, 25), UserName = "Tom@5023" };
            ApplicationUser a22 = new ApplicationUser() { FirstName = "Fanis", LastName = "Labropoulos", DateOfBirth = new DateTime(2005, 02, 27), UserName = "f_lab123" };
            ApplicationUser a23 = new ApplicationUser() { FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1994, 12, 01), UserName = "JohnDoe93" };
            ApplicationUser a24 = new ApplicationUser() { FirstName = "Mary", LastName = "Doe", DateOfBirth = new DateTime(1961, 08, 28), UserName = "DoeFam" };
            ApplicationUser a25 = new ApplicationUser() { FirstName = "Ean", LastName = "Velez", DateOfBirth = new DateTime(1998, 02, 16), UserName = "Scorpion" };
            ApplicationUser a26 = new ApplicationUser() { FirstName = "Brooks", LastName = "Sims", DateOfBirth = new DateTime(1952, 12, 16), UserName = "TheBig" };
            ApplicationUser a27 = new ApplicationUser() { FirstName = "Ashton", LastName = "Wells", DateOfBirth = new DateTime(1985, 11, 07), UserName = "BeWellMyFriend" };
            ApplicationUser a28 = new ApplicationUser() { FirstName = "Jaslene", LastName = "Mann", DateOfBirth = new DateTime(1966, 06, 02), UserName = "AljcaX" };
            ApplicationUser a29 = new ApplicationUser() { FirstName = "Daisy", LastName = "Barton", DateOfBirth = new DateTime(1978, 03, 06), UserName = "xXxRIPxXX" };
            ApplicationUser a30 = new ApplicationUser() { FirstName = "Walker", LastName = "Mahoney", DateOfBirth = new DateTime(1994, 02, 16), UserName = "TheCop" };
            ApplicationUser a31 = new ApplicationUser() { FirstName = "Ximena", LastName = "Alexander", DateOfBirth = new DateTime(1995, 12, 21), UserName = "Heman" };
            ApplicationUser a32 = new ApplicationUser() { FirstName = "Frida", LastName = "Murillo", DateOfBirth = new DateTime(1968, 04, 20), UserName = "nusdaaSW" };
            ApplicationUser a33 = new ApplicationUser() { FirstName = "Quincy", LastName = "Parrish", DateOfBirth = new DateTime(1998, 11, 15), UserName = "QuincyQuincy" };
            ApplicationUser a34 = new ApplicationUser() { FirstName = "Alan", LastName = "Hester", DateOfBirth = new DateTime(1991, 03, 18), UserName = "HesterF" };
            ApplicationUser a35 = new ApplicationUser() { FirstName = "Marilyn", LastName = "Johns", DateOfBirth = new DateTime(1985, 05, 16), UserName = "MarJJ24" };
            ApplicationUser a36 = new ApplicationUser() { FirstName = "Luciano", LastName = "Chung", DateOfBirth = new DateTime(1987, 03, 19), UserName = "ChungMan!" };
            ApplicationUser a37 = new ApplicationUser() { FirstName = "Ruslan", LastName = "Koval", DateOfBirth = new DateTime(1999, 12, 27), UserName = "TheRusGuy" };
            ApplicationUser a38 = new ApplicationUser() { FirstName = "Sof", LastName = "Petrou", DateOfBirth = new DateTime(2000, 01, 1), UserName = "TheMilenium" };
            ApplicationUser a39 = new ApplicationUser() { FirstName = "Lebron", LastName = "James", DateOfBirth = new DateTime(1974, 09, 14), UserName = "KingJames" };
            ApplicationUser a40 = new ApplicationUser() { FirstName = "Nikos", LastName = "Kotsabasis", DateOfBirth = new DateTime(1999, 05, 26), UserName = "TheHunter23" };

            // *** ~~~ ~~~ ~~~ *** Tags *** ~~~ ~~~ ~~~ ***

            Tag tg1 = new Tag() { Title = "C#", Description = "C# is a modern all purpose programming language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7a/C_Sharp_logo.svg" };
            Tag tg2 = new Tag() { Title = "JavaScript", Description = "Javascript is the de facto language of front end development.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/99/Unofficial_JavaScript_logo_2.svg" };
            Tag tg3 = new Tag() { Title = "Laravel", Description = "Laravel is an open-source PHP framework for developing web applications.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Laravel.svg" };
            Tag tg4 = new Tag() { Title = "C", Description = "C is a very fast and close to the system language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/35/The_C_Programming_Language_logo.svg" };
            Tag tg5 = new Tag() { Title = "C++", Description = "C++ added classes to the C language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/18/ISO_C%2B%2B_Logo.svg" };
            Tag tg6 = new Tag() { Title = "HTML", Description = "Hyper Text Markup Language\'s main application is constructing web sites.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/61/HTML5_logo_and_wordmark.svg" };
            Tag tg7 = new Tag() { Title = "Python", Description = "Easier language to learn. Useful at statistics.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/Python-logo-notext.svg" };
            Tag tg8 = new Tag() { Title = "Java", Description = "Very useful object-oriented programming language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/de/e/e1/Java-Logo.svg" };
            Tag tg9 = new Tag() { Title = "Asp.net", Description = "Web framework, created by Microsoft.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/13/Asp.net.svg" };
            Tag tg10 = new Tag() { Title = "Haskell", Description = "General purpose purely functional programming language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1c/Haskell-Logo.svg" };
            Tag tg11 = new Tag() { Title = "Kotlin", Description = "Kotlin is designed to interoperate fully with Java, and the JVM version", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/74/Kotlin-logo.svg" };
            Tag tg12 = new Tag() { Title = "F#", Description = "F# is most often used as a cross-platform Common Language Infrastructure programming language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Fsharp%2C_Logomark%2C_October_2014.svg" };
            Tag tg13 = new Tag() { Title = "TypeScript", Description = "TypeScript extends JavaScript by adding types to the language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/67/TypeScript_Logo.svg" };
            Tag tg14 = new Tag() { Title = "Jython", Description = "Jython is a Java implementation of Python that combines expressive power.", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/ea/Jython.png" };
            Tag tg15 = new Tag() { Title = "Ruby", Description = "Ruby is an interpreted, high-level, general-purpose programming language.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/73/Ruby_logo.svg" };
            Tag tg16 = new Tag() { Title = "PHP", Description = "General-purpose scripting language that is especially suited to web development.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/27/PHP-logo.svg" };
            Tag tg17 = new Tag() { Title = "Vue", Description = "Vue is an open-source JavaScript framework for building user interfaces.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/95/Vue.js_Logo_2.svg" };
            Tag tg18 = new Tag() { Title = "Ember", Description = "Battle-tested JavaScript framework for building modern web applications.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/27/Ember-logo.png" };
            Tag tg19 = new Tag() { Title = "React", Description = "A JavaScript library, React makes it painless to create interactive user interfaces.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a7/React-icon.svg" };
            Tag tg20 = new Tag() { Title = "Angular", Description = "Angular is an app design framework for creating efficient and sophisticated single-page apps.", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Angular_full_color_logo.svg" };

            // *** ~~~ ~~~ ~~~ *** Posts *** ~~~ ~~~ ~~~ ***

            var admin = userManager1.FindByEmail("admin1@gmail.com");


            Post p1 = new Post() { ApplicationUser = a1, Title = "Printing a string", Text = "Hello from me , I would like to make a question .If anybody could help me please.I want to print a string multiple times at the console using C#", PostDate = new DateTime(2019, 06, 18, 7, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r1_1 = new Reply() { ApplicationUser = a2, Post = p1, Text = "Use the Console.WriteLine function!", PostDate = new DateTime(2019, 06, 18, 7, 15, 0) };
            Reply r1_2 = new Reply() { ApplicationUser = a5, Post = p1, Text = "Use the for statement combined with Console.WriteLine!", PostDate = new DateTime(2019, 06, 18, 7, 30, 0) };

            Post p2 = new Post() { ApplicationUser = a2, Title = "How to select an element", Text = "Hellooo , Im a new Programmer and I need some Help.I would like to select a HTML element using JS", PostDate = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r2_1 = new Reply() { ApplicationUser = a1, Post = p2, Text = "One solution is to select by id, using getElementById", PostDate = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r2_2 = new Reply() { ApplicationUser = a4, Post = p2, Text = "You may also use querySelector, for css selectors", PostDate = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r2_3 = new Reply() { ApplicationUser = a5, Post = p2, Text = "There is also querySelectorAll for multiple results", PostDate = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p3 = new Post() { ApplicationUser = a3, Title = "How to create a new context per every async", Text = "Hi,please somenone to explain me some things.I want to work Async", PostDate = new DateTime(2019, 06, 18, 7, 0, 0), Tags = new List<Tag>() { tg2, tg4, tg6 } };
            Reply r3_1 = new Reply() { ApplicationUser = a1, Post = p3, Text = "What do you mean by create a stack of scopes, per every new async operation? If you have methodA calls methodB, and both are async methods, do you mean you want to create two scopes one for each?", PostDate = new DateTime(2019, 06, 18, 7, 15, 0) };
            Reply r3_2 = new Reply() { ApplicationUser = a2, Post = p3, Text = "You can also use querySelector, for css selectors", PostDate = new DateTime(2019, 06, 18, 7, 30, 0) };
            Reply r3_3 = new Reply() { ApplicationUser = a5, Post = p3, Text = "There is querySelectorAll", PostDate = new DateTime(2019, 06, 18, 7, 35, 0) };

            Post p4 = new Post() { ApplicationUser = a4, Title = "Top 52 C# Interview Questions & Answers", Text = "Hello , Im a junior Programmer and I need some Help.What is C#?", PostDate = new DateTime(2019, 01, 20, 16, 0, 0), Tags = new List<Tag>() { tg1, tg3 } };
            Reply r4_1 = new Reply() { ApplicationUser = a2, Post = p4, Text = "C# is an object-oriented, type-safe, and managed language that is compiled by .Net framework to generate Microsoft Intermediate Language.", PostDate = new DateTime(2019, 01, 20, 16, 7, 0) };
            Reply r4_2 = new Reply() { ApplicationUser = a3, Post = p4, Text = "You may also use querySelector for css selectors", PostDate = new DateTime(2019, 01, 21, 16, 17, 0) };
            Reply r4_3 = new Reply() { ApplicationUser = a7, Post = p4, Text = "There is also querySelectorAll for multiple results", PostDate = new DateTime(2019, 01, 21, 17, 18, 0) };

            Post p5 = new Post() { ApplicationUser = a5, Title = "Boxing and Unboxing", Text = "Heeelllppp!Maybe my question , is a cap of tea for the most of you here.What is Boxing and Unboxing in C#", PostDate = new DateTime(2019, 02, 28, 16, 0, 0), Tags = new List<Tag>() { tg1, tg8 } };
            Reply r5_1 = new Reply() { ApplicationUser = a1, Post = p5, Text = "Boxing and Unboxing both are used for type conversions.", PostDate = new DateTime(2019, 02, 28, 19, 7, 0) };
            Reply r5_2 = new Reply() { ApplicationUser = a2, Post = p5, Text = "The process of converting from a value type to a reference type is called boxing.", PostDate = new DateTime(2019, 03, 27, 12, 14, 0) };
            Reply r5_3 = new Reply() { ApplicationUser = a3, Post = p5, Text = "The process of converting from a reference type to a value type is called unboxing. Here is an example of unboxing in C#.", PostDate = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p6 = new Post() { ApplicationUser = a5, Title = "struct and class in C#", Text = "  Hello from me , I would like to make a question.If anybody could help me please.What is the difference between a struct and a class in C#?", PostDate = new DateTime(2019, 04, 28, 16, 0, 0), Tags = new List<Tag>() { tg10, tg11 } };
            Reply r6_1 = new Reply() { ApplicationUser = a3, Post = p6, Text = "The struct is a value type in C# and it inherits from System.Value Type.Struct is usually used for smaller amounts of data.The class is a reference type in C# and it inherits from the System.Object Type", PostDate = new DateTime(2019, 04, 28, 16, 7, 0) };
            Reply r6_2 = new Reply() { ApplicationUser = a1, Post = p6, Text = "Struct can’t be inherited from other types.A structure can't be abstract", PostDate = new DateTime(2019, 04, 28, 16, 14, 0) };
            Reply r6_3 = new Reply() { ApplicationUser = a15, Post = p6, Text = "A class can be an abstract type.Classes can be inherited from other classes", PostDate = new DateTime(2019, 04, 28, 17, 18, 0) };

            Post p7 = new Post() { ApplicationUser = a9, Title = "Interface and Abstract Class in C#", Text = "Hellooo , Im a new Programmer and I need some Help.What is the difference between Interface and Abstract Class in C#?", PostDate = new DateTime(2019, 11, 24, 16, 0, 0), Tags = new List<Tag>() { tg1, tg7 } };
            Reply r7_1 = new Reply() { ApplicationUser = a2, Post = p7, Text = "A class can implement any number of interfaces but a subclass can at most use only one abstract class.An abstract class can have non-abstract methods(concrete methods) while in case of interface, all the methods have to be abstract.", PostDate = new DateTime(2019, 11, 25, 16, 9, 0) };
            Reply r7_2 = new Reply() { ApplicationUser = a3, Post = p7, Text = "An abstract class can declare or use any variables while an interface is not allowed to do so.In an abstract class, all data members or functions are private by default while in an interface all are public, we can’t change them manually.", PostDate = new DateTime(2019, 11, 25, 16, 14, 0) };
            Reply r7_3 = new Reply() { ApplicationUser = a5, Post = p7, Text = "In an abstract class, we need to use abstract keywords to declare abstract methods, while in an interface we don’t need to use that.", PostDate = new DateTime(2019, 11, 26, 18, 18, 0) };

            Post p8 = new Post() { ApplicationUser = a10, Title = "Enum in C#", Text = "Hi,please somenone to explain me some things.What is enum in C#?", PostDate = new DateTime(2019, 07, 28, 16, 0, 0), Tags = new List<Tag>() { tg12, tg13 } };
            Reply r8_1 = new Reply() { ApplicationUser = a1, Post = p8, Text = "An enum is a value type with a set of related named constants often referred to as an enumerator list. The enum keyword is used to declare an enumeration. It is a primitive data type that is user-defined.", PostDate = new DateTime(2019, 07, 28, 16, 7, 0) };
            Reply r8_2 = new Reply() { ApplicationUser = a4, Post = p8, Text = "An enum type can be an integer (float, int, byte, double, etc.). But if you use it beside int it has to be cast.", PostDate = new DateTime(2019, 07, 28, 16, 14, 0) };
            Reply r8_3 = new Reply() { ApplicationUser = a2, Post = p8, Text = "An enum is used to create numeric constants in the .NET framework. All the members of enum are enum type. There must be a numeric value for each enum type.", PostDate = new DateTime(2019, 07, 28, 17, 18, 0) };
            Reply r8_4 = new Reply() { ApplicationUser = admin, Post = p8, Text = "An enum iqweqws used to create numeric constants in the .NET framework. All the members of enum are enum type. There must be a numeric value for each enum type.", PostDate = new DateTime(2019, 07, 28, 17, 18, 0) };

            Post p9 = new Post() { ApplicationUser = a11, Title = "Continue and Break statements", Text = "Hello , Im a junior Programmer and I need some Help.Whats the diffence of Continue and Break statements", PostDate = new DateTime(2019, 02, 15, 16, 0, 0), Tags = new List<Tag>() { tg1, tg4, tg5 } };
            Reply r9_1 = new Reply() { ApplicationUser = a1, Post = p9, Text = "Using break statement, you can 'jump out of a loop' whereas by using a continue statement, you can 'jump over one iteration' and then resume your loop execution", PostDate = new DateTime(2019, 02, 15, 16, 7, 0) };
            Reply r9_2 = new Reply() { ApplicationUser = a4, Post = p9, Text = "The continue statement passes control to the next iteration", PostDate = new DateTime(2019, 02, 15, 16, 14, 0) };
            Reply r9_3 = new Reply() { ApplicationUser = a3, Post = p9, Text = " you can 'jump over one iteration' and then resume your loop execution", PostDate = new DateTime(2019, 02, 15, 17, 18, 0) };
            Reply r9_4 = new Reply() { ApplicationUser = admin, Post = p9, Text = " you can 'jump ovwqeqweer one iteration' and then resume your loop execution", PostDate = new DateTime(2019, 02, 15, 17, 18, 0) };

            Post p10 = new Post() { ApplicationUser = a11, Title = "Constant and readonly in C#", Text = "Heeelllppp!Maybe my question , is a cap of tea for the most of you here.What is the difference between constant and readonly in C#?", PostDate = new DateTime(2019, 12, 28, 16, 0, 0), Tags = new List<Tag>() { tg5, tg3, tg6 } };
            Reply r10_1 = new Reply() { ApplicationUser = a1, Post = p10, Text = "Const is nothing but constant, a variable of which the value is constant but at compile time.", PostDate = new DateTime(2019, 12, 18, 17, 7, 0) };
            Reply r10_2 = new Reply() { ApplicationUser = a4, Post = p10, Text = "By default, a const is static and we cannot change the value of a const variable throughout the entire program.", PostDate = new DateTime(2019, 12, 28, 18, 14, 0) };
            Reply r10_3 = new Reply() { ApplicationUser = a2, Post = p10, Text = "Readonly is the keyword whose value we can change during runtime or we can assign it at run time but only through the non-static constructor.", PostDate = new DateTime(2019, 12, 28, 20, 14, 0) };


            Post p11 = new Post() { ApplicationUser = a12, Title = "Ref and out keywords", Text = "Hello from me , I would like to make a question.If anybody could help me please.What is the difference between ref and out keywords?", PostDate = new DateTime(2019, 05, 29, 16, 0, 0), Tags = new List<Tag>() { tg15, tg16 } };
            Reply r11_1 = new Reply() { ApplicationUser = a1, Post = p11, Text = "The ref keyword passes arguments by reference. It means any changes made to this argument in the method will be reflected in that variable when control returns to the calling method.", PostDate = new DateTime(2019, 05, 29, 16, 23, 0) };
            Reply r11_2 = new Reply() { ApplicationUser = a2, Post = p11, Text = "The out keyword passes arguments by reference. This is very similar to the ref keyword.", PostDate = new DateTime(2019, 05, 29, 18, 14, 0) };
            Reply r11_3 = new Reply() { ApplicationUser = a3, Post = p11, Text = "Both ref and out are treated differently at run time and they are treated the same at compile time, so methods cannot be overloaded if one method takes an argument as ref and the other takes an argument as an out.", PostDate = new DateTime(2019, 06, 30, 17, 18, 0) };

            Post p12 = new Post() { ApplicationUser = a13, Title = "'This' keyword with static Methods C# ", Text = "Hellooo , Im a new Programmer and I need some Help.Can 'this' be used within a static method?", PostDate = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg17, tg19 } };
            Reply r12_1 = new Reply() { ApplicationUser = a4, Post = p12, Text = "We can't use 'this' in a static method because the keyword 'this' returns a reference to the current instance of the class containing it.", PostDate = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r12_2 = new Reply() { ApplicationUser = a5, Post = p12, Text = "Static methods (or any static member) do not belong to a particular instance. They exist without creating an instance of the class and are called with the name of a class, not by instance, so we can’t use this keyword in the body of static Methods.", PostDate = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r12_3 = new Reply() { ApplicationUser = a1, Post = p12, Text = "The 'this' keyword in C# is a special type of reference variable that is implicitly defined within each constructor and non-static method as a first parameter of the type class in which it is defined.", PostDate = new DateTime(2019, 12, 30, 17, 18, 0) };

            Post p13 = new Post() { ApplicationUser = a14, Title = "Comments in HTML", Text = "Hi,please somenone to explain me some things.How can I insert a comment in HTML?", PostDate = new DateTime(2019, 06, 30, 16, 0, 0), Tags = new List<Tag>() { tg19, tg20 } };
            Reply r13_1 = new Reply() { ApplicationUser = a1, Post = p13, Text = "Comments in HTML begins with <!–ends with–>.", PostDate = new DateTime(2019, 06, 30, 16, 7, 0) };
            Reply r13_2 = new Reply() { ApplicationUser = a8, Post = p13, Text = "<!--/-->That is exactly!", PostDate = new DateTime(2019, 06, 30, 16, 14, 0) };
            Reply r13_3 = new Reply() { ApplicationUser = a5, Post = p13, Text = "<!-- A SAMPLE COMMENT -->", PostDate = new DateTime(2019, 06, 30, 17, 19, 0) };

            Post p14 = new Post() { ApplicationUser = a15, Title = "Image map", Text = "Hello , Im a junior Programmer and I need some Help.What is an image map?", PostDate = new DateTime(2019, 01, 12, 16, 0, 0), Tags = new List<Tag>() { tg6 } };
            Reply r14_1 = new Reply() { ApplicationUser = a1, Post = p14, Text = "Image map lets you link to many different web pages using a single image.", PostDate = new DateTime(2019, 01, 12, 16, 7, 0) };
            Reply r14_2 = new Reply() { ApplicationUser = a4, Post = p14, Text = "You can define shapes in images that you want to make part of an image mapping.", PostDate = new DateTime(2019, 01, 12, 16, 14, 0) };
            Reply r14_3 = new Reply() { ApplicationUser = a1, Post = p14, Text = "You also define shapes in images ", PostDate = new DateTime(2019, 01, 12, 17, 18, 0) };

            Post p15 = new Post() { ApplicationUser = a16, Title = "Collapsing white space", Text = "Heeelllppp!Maybe my question , is a cap of tea for the most of you here.What is the advantage of collapsing white space?", PostDate = new DateTime(2019, 03, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r15_1 = new Reply() { ApplicationUser = a1, Post = p15, Text = "White spaces are a blank sequence of space characters, which is treated as a single space character in HTML.", PostDate = new DateTime(2019, 03, 30, 16, 7, 0) };
            Reply r15_2 = new Reply() { ApplicationUser = a14, Post = p15, Text = "Because the browser collapses multiple spaces into a single space, you can indent lines of text without worrying about multiple spaces.", PostDate = new DateTime(2019, 03, 30, 16, 14, 0) };
            Reply r15_3 = new Reply() { ApplicationUser = a18, Post = p15, Text = "This enables you to organize the HTML code into a much more readable format.", PostDate = new DateTime(2019, 03, 30, 18, 18, 0) };

            Post p16 = new Post() { ApplicationUser = a17, Title = "Properties in C#", Text = "Hellooo , Im a new Programmer and I need some Help.What are Properties in C#?", PostDate = new DateTime(2019, 02, 25, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r16_1 = new Reply() { ApplicationUser = a19, Post = p16, Text = "C# properties are members of a C# class that provide a flexible mechanism to read", PostDate = new DateTime(2019, 02, 25, 16, 7, 0) };
            Reply r16_2 = new Reply() { ApplicationUser = a6, Post = p16, Text = "C# properties use get and set methods, also known as accessors, to access and assign values to private fields.", PostDate = new DateTime(2019, 02, 25, 16, 17, 0) };
            Reply r16_3 = new Reply() { ApplicationUser = a5, Post = p16, Text = "Properties in C# are always public data members.", PostDate = new DateTime(2019, 02, 25, 17, 21, 0) };

            Post p17 = new Post() { ApplicationUser = a18, Title = "Extensions Methods", Text = "Heeelllppp!Maybe my question , is a cap of tea for the most of you here.What are extension methods in C#?", PostDate = new DateTime(2019, 03, 12, 17, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r17_1 = new Reply() { ApplicationUser = a19, Post = p17, Text = "Extension methods enable you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. ", PostDate = new DateTime(2019, 03, 12, 18, 7, 0) };
            Reply r17_2 = new Reply() { ApplicationUser = a14, Post = p17, Text = "An extension method is a special kind of static method, but they are called as if they were instance methods on the extended type.", PostDate = new DateTime(2019, 03, 12, 19, 14, 0) };
            Reply r17_3 = new Reply() { ApplicationUser = a2, Post = p17, Text = "An extension method is a static method of a static class, where the 'this' modifier is applied to the first parameter. The type of the first parameter will be the type that is extended.", PostDate = new DateTime(2019, 03, 12, 20, 18, 0) };



            Post p18 = new Post() { ApplicationUser = a19, Title = "Dispose and finalize methods in C#?", Text = "Hellooo , Im a new Programmer and I need some Help.What is the difference between the dispose and finalize methods in C#?", PostDate = new DateTime(2019, 01, 23, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r18_1 = new Reply() { ApplicationUser = a7, Post = p18, Text = "In finalize and dispose, both methods are used to free unmanaged resources.", PostDate = new DateTime(2019, 01, 23, 17, 8, 0) };
            Reply r18_2 = new Reply() { ApplicationUser = a4, Post = p18, Text = "Finalize is used to free unmanaged resources that are not in use, like files, database connections in the application domain and more. These are resources held by an object before that object is destroyed.", PostDate = new DateTime(2019, 01, 23, 19, 14, 0) };
            Reply r18_3 = new Reply() { ApplicationUser = a20, Post = p18, Text = "In the Internal process, it is called by Garbage Collector and can’t be called manual by user code or any service.", PostDate = new DateTime(2019, 01, 23, 20, 18, 0) };

            Post p19 = new Post() { ApplicationUser = a20, Title = "String and StringBuilder in C#", Text = "Hi,please somenone to explain me some things.What is the difference between String and StringBuilder in C#?", PostDate = new DateTime(2019, 02, 13, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r19_1 = new Reply() { ApplicationUser = a1, Post = p19, Text = "StringBuilder and string are both used to string values, but both have many differences on the bases of instance creation and also in performance.", PostDate = new DateTime(2019, 02, 13, 16, 7, 0) };
            Reply r19_2 = new Reply() { ApplicationUser = a8, Post = p19, Text = "A string is an immutable object. Immutable is when we create string objects in code so we cannot modify or change that object in any operations like insert new value, replace or append any value with the existing value in a string object.", PostDate = new DateTime(2019, 02, 13, 16, 14, 0) };
            Reply r19_3 = new Reply() { ApplicationUser = a10, Post = p19, Text = "System.Text.Stringbuilder is a mutable object which also holds the string value, mutable means once we create a System.Text.Stringbuilder object. ", PostDate = new DateTime(2019, 02, 13, 17, 18, 0) };

            Post p20 = new Post() { ApplicationUser = a16, Title = "Delegates in C# and the uses of delegates", Text = "Hello , Im a junior Programmer and I need some Help.What are delegates?", PostDate = new DateTime(2019, 05, 27, 10, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r20_1 = new Reply() { ApplicationUser = a18, Post = p20, Text = "A Delegate is an abstraction of one or more function pointers", PostDate = new DateTime(2019, 05, 28, 16, 7, 0) };
            Reply r20_2 = new Reply() { ApplicationUser = a17, Post = p20, Text = "Delegates are derived from the System.MulticastDelegate class.They have a signature and a return type.A function that is added to delegates must be compatible with this signature.", PostDate = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r20_3 = new Reply() { ApplicationUser = a5, Post = p20, Text = "Delegates can point to either static or instance methods", PostDate = new DateTime(2019, 05, 29, 20, 18, 0) };

            Post p21 = new Post() { ApplicationUser = a18, Title = "Bootstrap colummns ", Text = "Heeelllppp!Maybe my question , is a cap of tea for the most of you here.How can I make columns all the same height?I dont think i need any CSS , so i would like to do that with Bootstrap", PostDate = new DateTime(2019, 08, 29, 13, 0, 0), Tags = new List<Tag>() { tg6 } };
            Reply r21_1 = new Reply() { ApplicationUser = a2, Post = p21, Text = "Bootstrap 4 uses Flexbox so there is no need for extra CSS ", PostDate = new DateTime(2019, 08, 30, 16, 7, 0) };
            Reply r21_2 = new Reply() { ApplicationUser = a11, Post = p21, Text = "To only apply the same height flexbox at specific breakpoints (responsive), use a media query.", PostDate = new DateTime(2019, 08, 30, 16, 14, 0) };
            Reply r21_3 = new Reply() { ApplicationUser = a12, Post = p21, Text = "Flexbox is now used by default in Bootstrap 4 so there is no need for the extra CSS to make equal height columns:", PostDate = new DateTime(2019, 08, 30, 19, 18, 0) };



            Post p22 = new Post() { ApplicationUser = a12, Title = "Delegates C#", Text = "Hello from me , I would like to make a question.If anybody could help me please.Why Do We Need Delegates?", PostDate = new DateTime(2019, 04, 12, 17, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r22_1 = new Reply() { ApplicationUser = a1, Post = p22, Text = "A delegate is a solution for situations in which you want to pass methods around to other methods.", PostDate = new DateTime(2019, 07, 12, 18, 7, 0) };
            Reply r22_2 = new Reply() { ApplicationUser = a8, Post = p22, Text = "You are so accustomed to passing data to methods as parameters that the idea of passing methods as an argument instead of data might sound a little strange.", PostDate = new DateTime(2019, 04, 12, 19, 14, 0) };
            Reply r22_3 = new Reply() { ApplicationUser = a7, Post = p22, Text = "The parameters of the method.The address of the method it calls.The return type of the method.", PostDate = new DateTime(2019, 04, 12, 21, 18, 0) };

            Post p23 = new Post() { ApplicationUser = a3, Title = "Sealed classes C#", Text = "Hellooo , Im a new Programmer and I need some Help.What are sealed classes in C#?", PostDate = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r23_1 = new Reply() { ApplicationUser = a1, Post = p23, Text = "Sealed classes are used to restrict the inheritance feature of object-oriented programming.", PostDate = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r23_2 = new Reply() { ApplicationUser = a14, Post = p23, Text = "Once a class is defined as a sealed class, the class cannot be inherited. ", PostDate = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r23_3 = new Reply() { ApplicationUser = a15, Post = p23, Text = "In C#, the sealed modifier is used to define a class as sealed. In Visual Basic .NET the Not Inheritable keyword serves the purpose of the sealed class.", PostDate = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p24 = new Post() { ApplicationUser = a20, Title = "What is IEnumerable<> in C#?", Text = "Hi,please somenone to explain me some things.Could someone explain me when to use Ienumerable?", PostDate = new DateTime(2019, 08, 29, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r24_1 = new Reply() { ApplicationUser = a12, Post = p24, Text = "IEnumerable is the parent interface for all non-generic collections in System.Collections namespace like ArrayList, HastTable etc. that can be enumerated", PostDate = new DateTime(2019, 08, 29, 16, 7, 0) };
            Reply r24_2 = new Reply() { ApplicationUser = a13, Post = p24, Text = "Enumerable in C# is an interface that defines one method, GetEnumerator which returns an IEnumerator interface. This allows readonly access to a collection then a collection that implements IEnumerable can be used with a for-each statement.", PostDate = new DateTime(2019, 08, 29, 17, 8, 0) };
            Reply r24_3 = new Reply() { ApplicationUser = a4, Post = p24, Text = "IEnumerable interface is a generic interface which allows looping over generic or non-generic lists.", PostDate = new DateTime(2019, 08, 29, 18, 14, 0) };
            Reply r24_4 = new Reply() { ApplicationUser = a14, Post = p24, Text = "IEnumerable interface also works with linq query expression.", PostDate = new DateTime(2019, 08, 29, 19, 15, 0) };
            Reply r24_5 = new Reply() { ApplicationUser = a15, Post = p24, Text = "IEnumerable interface Returns an enumerator that iterates through the collection.", PostDate = new DateTime(2019, 08, 30, 17, 18, 0) };
            Reply r24_6 = new Reply() { ApplicationUser = a5, Post = p24, Text = "IEnumerator is an interface which helps to get current elements from the collection, it has the following two methods", PostDate = new DateTime(2019, 08, 30, 18, 18, 0) };

            Post p25 = new Post() { ApplicationUser = a5, Title = "key features of Python", Text = "Hello , Im a junior Programmer and I need some Help.What are the key features of Python?", PostDate = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg7 } };
            Reply r25_1 = new Reply() { ApplicationUser = a2, Post = p25, Text = "Python is an interpreted language. That means that, unlike languages like C and its variants, Python does not need to be compiled before it is run. Other interpreted languages include PHP and Ruby.", PostDate = new DateTime(2019, 07, 30, 16, 9, 0) };
            Reply r25_2 = new Reply() { ApplicationUser = a3, Post = p25, Text = "Python is well suited to object orientated programming in that it allows the definition of classes along with composition and inheritance. Python does not have access specifiers (like C++’s public, private).", PostDate = new DateTime(2019, 07, 30, 16, 24, 0) };
            Reply r25_3 = new Reply() { ApplicationUser = a13, Post = p25, Text = "In Python, functions are first-class objects. This means that they can be assigned to variables, returned from other functions and passed into functions. Classes are also first class objects", PostDate = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p26 = new Post() { ApplicationUser = a3, Title = "Python Type of Language", Text = "Hello , Im a junior Programmer and I need some Help again from Loop team.What type of language is python? Programming or scripting?", PostDate = new DateTime(2019, 09, 13, 16, 0, 0), Tags = new List<Tag>() { tg7 } };
            Reply r26_1 = new Reply() { ApplicationUser = a1, Post = p26, Text = "Python is capable of scripting, but in general sense, it is considered as a general-purpose programming language", PostDate = new DateTime(2019, 09, 13, 16, 7, 0) };
            Reply r26_2 = new Reply() { ApplicationUser = a4, Post = p26, Text = "General-purpose programming language.", PostDate = new DateTime(2019, 09, 13, 16, 14, 0) };
            Reply r26_3 = new Reply() { ApplicationUser = a5, Post = p26, Text = "Capable of scripting, but in general sense, it is considered as a general-purpose programming language", PostDate = new DateTime(2019, 09, 13, 17, 18, 0) };

            Post p27 = new Post() { ApplicationUser = a3, Title = "Memory managed in Python", Text = "Heeelllppp!Maybe my question , is a cap of tea for the most of you here.How is memory managed in Python?", PostDate = new DateTime(2019, 07, 10, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r27_1 = new Reply() { ApplicationUser = a1, Post = p27, Text = "Memory management in python is managed by Python private heap space. All Python objects and data structures are located in a private heap. The programmer does not have access to this private heap. The python interpreter takes care of this instead", PostDate = new DateTime(2019, 07, 10, 16, 7, 0) };
            Reply r27_2 = new Reply() { ApplicationUser = a4, Post = p27, Text = "The allocation of heap space for Python objects is done by Python’s memory manager. The core API gives access to some tools for the programmer to code.", PostDate = new DateTime(2019, 07, 10, 16, 14, 0) };
            Reply r27_3 = new Reply() { ApplicationUser = a15, Post = p27, Text = "Python also has an inbuilt garbage collector, which recycles all the unused memory and so that it can be made available to the heap space.", PostDate = new DateTime(2019, 07, 10, 17, 18, 0) };





            Post p28 = new Post() { ApplicationUser = a7, Title = "Python Django", Text = "Hello from me , I would like to make a question.If anybody could help me pleaseWhat is the difference between Django, Pyramid, and Flask?", PostDate = new DateTime(2019, 03, 21, 16, 0, 0), Tags = new List<Tag>() { tg7 } };
            Reply r28_1 = new Reply() { ApplicationUser = a1, Post = p28, Text = "Flask is a microframework primarily build for a small application with simpler requirements. In flask, you don't have to use external libraries. Flask is ready to use.", PostDate = new DateTime(2019, 03, 21, 16, 7, 0) };
            Reply r28_2 = new Reply() { ApplicationUser = a2, Post = p28, Text = "Pyramid are build for larger applications. It provides flexibility and lets the developer use the right tools for their project. The developer can choose the database, URL structure, templating style and more. Pyramid is heavy configurable.", PostDate = new DateTime(2019, 03, 21, 16, 14, 0) };
            Reply r28_3 = new Reply() { ApplicationUser = a6, Post = p28, Text = "Like Pyramid, Django can also used for larger applications. It includes an ORM.", PostDate = new DateTime(2019, 03, 21, 17, 18, 0) };

            Post p29 = new Post() { ApplicationUser = a1, Title = "Java loops", Text = "Hellooo , Im a new Programmer and I need some Help.How do I break out of nested loops in Java?", PostDate = new DateTime(2019, 04, 28, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r29_1 = new Reply() { ApplicationUser = a3, Post = p29, Text = "You can use break with a label for the outer loop.", PostDate = new DateTime(2019, 04, 28, 16, 7, 0) };
            Reply r29_2 = new Reply() { ApplicationUser = a4, Post = p29, Text = "I'd definitely prefer to put the loops in a different method, at which point you can just return to stop iterating completely.", PostDate = new DateTime(2019, 04, 28, 16, 14, 0) };
            Reply r29_3 = new Reply() { ApplicationUser = a15, Post = p29, Text = "Just use the brake", PostDate = new DateTime(2019, 04, 28, 17, 18, 0) };

            Post p30 = new Post() { ApplicationUser = a9, Title = "JDK, JRE, and JVM ", Text = "Hi,please somenone to explain me some things.What is the difference between JDK, JRE, and JVM?", PostDate = new DateTime(2019, 11, 24, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r30_1 = new Reply() { ApplicationUser = a2, Post = p30, Text = "JVM is an acronym for Java Virtual Machine; it is an abstract machine which provides the runtime environment in which Java bytecode can be executed. It is a specification which specifies the working of Java Virtual Machine. Its implementation has been provided by Oracle and other companies. Its implementation is known as JRE.", PostDate = new DateTime(2019, 11, 25, 16, 9, 0) };
            Reply r30_2 = new Reply() { ApplicationUser = a3, Post = p30, Text = "JVMs are available for many hardware and software platforms (so JVM is platform dependent). It is a runtime instance which is created when we run the Java class. There are three notions of the JVM: specification, implementation, and instance.", PostDate = new DateTime(2019, 11, 25, 16, 14, 0) };
            Reply r30_3 = new Reply() { ApplicationUser = a5, Post = p30, Text = "JRE stands for Java Runtime Environment. It is the implementation of JVM. The Java Runtime Environment is a set of software tools which are used for developing Java applications. It is used to provide the runtime environment. It is the implementation of JVM. It physically exists. It contains a set of libraries + other files that JVM uses at runtime.", PostDate = new DateTime(2019, 11, 26, 18, 18, 0) };

            Post p31 = new Post() { ApplicationUser = a10, Title = "JVM Java", Text = "Hello , Im a junior Programmer and I need some Help.How many types of memory areas are allocated by JVM?", PostDate = new DateTime(2019, 07, 28, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r31_1 = new Reply() { ApplicationUser = a1, Post = p31, Text = "Class(Method) Area: Class Area stores per-class structures such as the runtime constant pool, field, method data, and the code for methods.", PostDate = new DateTime(2019, 07, 28, 16, 7, 0) };
            Reply r31_2 = new Reply() { ApplicationUser = a4, Post = p31, Text = "Heap: It is the runtime data area in which the memory is allocated to the objectsStack: Java Stack stores frames.", PostDate = new DateTime(2019, 07, 28, 16, 14, 0) };
            Reply r31_3 = new Reply() { ApplicationUser = a2, Post = p31, Text = "Program Counter Register: PC (program counter) register contains the address of the Java virtual machine instruction currently being executed.Native Method Stack: It contains all the native methods used in the application.", PostDate = new DateTime(2019, 07, 28, 17, 18, 0) };

            Post p32 = new Post() { ApplicationUser = a11, Title = "Differences between the Java platform and other platforms", Text = "Heeelllppp!Maybe my question , is a cap of tea for the most of you here.What are the main differences between the Java platform and other platforms?", PostDate = new DateTime(2019, 02, 15, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r32_1 = new Reply() { ApplicationUser = a1, Post = p32, Text = "Java is the software-based platform whereas other platforms may be the hardware platforms or software-based platforms.", PostDate = new DateTime(2019, 02, 15, 16, 7, 0) };
            Reply r32_2 = new Reply() { ApplicationUser = a4, Post = p32, Text = "Java is executed on the top of other hardware platforms whereas other platforms can only have the hardware components.", PostDate = new DateTime(2019, 02, 15, 16, 14, 0) };
            Reply r32_3 = new Reply() { ApplicationUser = a3, Post = p32, Text = "Java is executed on the top of other hardware platforms", PostDate = new DateTime(2019, 02, 15, 17, 18, 0) };

            Post p33 = new Post() { ApplicationUser = a11, Title = "Classloader", Text = "Hello from me , I would like to make a question.If anybody could help me please.What is classloader??", PostDate = new DateTime(2019, 12, 28, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r33_1 = new Reply() { ApplicationUser = a1, Post = p33, Text = "Bootstrap ClassLoader: This is the first classloader which is the superclass of Extension classloader. It loads the rt.jar file which contains all class files of Java Standard Edition like java.lang package classes, java.net package classes, java.util package classes, java.io package classes, java.sql package classes, etc.", PostDate = new DateTime(2019, 12, 18, 17, 7, 0) };
            Reply r33_2 = new Reply() { ApplicationUser = a4, Post = p33, Text = "Extension ClassLoader: This is the child classloader of Bootstrap and parent classloader of System classloader. It loads the jar files located inside $JAVA_HOME/jre/lib/ext directory.", PostDate = new DateTime(2019, 12, 28, 18, 14, 0) };
            Reply r33_3 = new Reply() { ApplicationUser = a2, Post = p33, Text = "System/Application ClassLoader: This is the child classloader of Extension classloader. It loads the class files from the classpath. By default, the classpath is set to the current directory. You can change the classpath using classpath switch. It is also known as Application classloader.", PostDate = new DateTime(2019, 12, 28, 20, 14, 0) };

            Post p34 = new Post() { ApplicationUser = a12, Title = "OOP Paradigm", Text = "Heeelllppp!Maybe my question , is a cap of tea for the most of you here.What is object-oriented paradigm??", PostDate = new DateTime(2019, 05, 29, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r34_1 = new Reply() { ApplicationUser = a1, Post = p34, Text = "It is a programming paradigm based on objects having data and methods defined in the class to which it belongs.", PostDate = new DateTime(2019, 05, 29, 16, 23, 0) };
            Reply r34_2 = new Reply() { ApplicationUser = a2, Post = p34, Text = "Object-oriented paradigm aims to incorporate the advantages of modularity and reusability. Objects are the instances of classes which interacts with one another to design applications and programs.", PostDate = new DateTime(2019, 05, 29, 18, 14, 0) };
            Reply r34_3 = new Reply() { ApplicationUser = a3, Post = p34, Text = "Includes the concept like Encapsulation and abstraction which hides the complexities from the user and show only functionality.", PostDate = new DateTime(2019, 06, 30, 17, 18, 0) };

            Post p35 = new Post() { ApplicationUser = a13, Title = "object-oriented programming language and object-based programming language ", Text = " What is the difference between an object-oriented programming language and object-based programming language?", PostDate = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r35_1 = new Reply() { ApplicationUser = a4, Post = p35, Text = "Object - oriented languages follow all the concepts of OOPs whereas,the object - based language doesn't follow all the concepts of OOPs like inheritance and polymorphism..", PostDate = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r35_2 = new Reply() { ApplicationUser = a5, Post = p35, Text = "Object-oriented languages do not have the inbuilt objects whereas Object-based languages have the inbuilt objects, for example, JavaScript has window object", PostDate = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r35_3 = new Reply() { ApplicationUser = a1, Post = p35, Text = "Examples of object-oriented programming are Java, C#, Smalltalk, etc. whereas the examples of object-based languages are JavaScript, VBScript, etc.", PostDate = new DateTime(2019, 12, 30, 17, 18, 0) };

            Post p36 = new Post() { ApplicationUser = a1, Title = "Static methods at Abstract class", Text = " Hello Everyone!Can I declare the static variables and methods in an abstract class?", PostDate = new DateTime(2019, 04, 28, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r36_1 = new Reply() { ApplicationUser = a3, Post = p36, Text = "Yes Of Course!", PostDate = new DateTime(2019, 04, 28, 16, 7, 0) };
            Reply r36_2 = new Reply() { ApplicationUser = a4, Post = p36, Text = "Yes, we can declare static variables and methods in an abstract method. ", PostDate = new DateTime(2019, 04, 28, 16, 14, 0) };
            Reply r36_3 = new Reply() { ApplicationUser = a15, Post = p36, Text = "As we know that there is no requirement to make the object to access the static context, therefore, we can access the static context declared inside the abstract class by using the name of the abstract class.", PostDate = new DateTime(2019, 04, 28, 17, 18, 0) };

            Post p37 = new Post() { ApplicationUser = a9, Title = "This keyword in java", Text = "Hello from me , I would like to make a question.If anybody could help me please.What is this keyword in java?", PostDate = new DateTime(2019, 11, 24, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r37_1 = new Reply() { ApplicationUser = a2, Post = p37, Text = "The this keyword is a reference variable that refers to the current object.", PostDate = new DateTime(2019, 11, 25, 16, 9, 0) };
            Reply r37_2 = new Reply() { ApplicationUser = a3, Post = p37, Text = "There are the various uses of this keyword in Java. It can be used to refer to current class properties such as instance methods, variable, constructors, etc.", PostDate = new DateTime(2019, 11, 25, 16, 14, 0) };
            Reply r37_3 = new Reply() { ApplicationUser = a5, Post = p37, Text = "It can also be passed as an argument into the methods or constructors. It can also be returned from the method as the current class instance.", PostDate = new DateTime(2019, 11, 26, 18, 18, 0) };

            Post p38 = new Post() { ApplicationUser = a10, Title = "This keyword uses in java", Text = "Hellooo , Im a new Programmer and I need some Help.What are the main uses of this keyword?", PostDate = new DateTime(2019, 07, 28, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r38_1 = new Reply() { ApplicationUser = a1, Post = p38, Text = "This can be used to refer to the current class instance variable", PostDate = new DateTime(2019, 07, 28, 16, 7, 0) };
            Reply r38_2 = new Reply() { ApplicationUser = a4, Post = p38, Text = "This can be used to invoke current class method (implicitly)", PostDate = new DateTime(2019, 07, 28, 16, 14, 0) };
            Reply r38_3 = new Reply() { ApplicationUser = a2, Post = p38, Text = "This() can be used to invoke the current class constructor.", PostDate = new DateTime(2019, 07, 28, 17, 18, 0) };

            Post p39 = new Post() { ApplicationUser = a11, Title = "Passing this into a Method-Java", Text = "What are the advantages of passing this into a method instead of the current class object itself?", PostDate = new DateTime(2019, 02, 15, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r39_1 = new Reply() { ApplicationUser = a1, Post = p39, Text = "As we know, that this refers to the current class object, therefore, it must be similar to the current class object.", PostDate = new DateTime(2019, 02, 15, 16, 7, 0) };
            Reply r39_2 = new Reply() { ApplicationUser = a4, Post = p39, Text = "this is a final variable. Therefore, this cannot be assigned to any new value whereas the current class object might not be final and can be changed.", PostDate = new DateTime(2019, 02, 15, 16, 14, 0) };
            Reply r39_3 = new Reply() { ApplicationUser = a3, Post = p39, Text = " this can be used in the synchronized block.", PostDate = new DateTime(2019, 02, 15, 17, 18, 0) };

            Post p40 = new Post() { ApplicationUser = a11, Title = "Inheritance Java", Text = "What is the Inheritance??", PostDate = new DateTime(2019, 12, 28, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r40_1 = new Reply() { ApplicationUser = a1, Post = p40, Text = "Inheritance is a mechanism by which one object acquires all the properties and behavior of another object of another class. It is used for Code Reusability and Method Overriding. The idea behind inheritance in Java is that you can create new classes that are built upon existing classes.", PostDate = new DateTime(2019, 12, 18, 17, 7, 0) };
            Reply r40_2 = new Reply() { ApplicationUser = a4, Post = p40, Text = "When you inherit from an existing class, you can reuse methods and fields of the parent class. ", PostDate = new DateTime(2019, 12, 28, 18, 14, 0) };
            Reply r40_3 = new Reply() { ApplicationUser = a2, Post = p40, Text = "Moreover, you can add new methods and fields in your current class also. Inheritance represents the IS-A relationship which is also known as a parent-child relationship..", PostDate = new DateTime(2019, 12, 28, 20, 14, 0) };

            Post p41 = new Post() { ApplicationUser = a12, Title = "Why is Inheritance used in Java?", Text = "Why is Inheritance used in Java and how usefull could be for a new Developer?", PostDate = new DateTime(2019, 05, 29, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r41_1 = new Reply() { ApplicationUser = a1, Post = p41, Text = "Inheritance provides code reusability. The derived class does not need to redefine the method of base class unless it needs to provide the specific implementation of the method.", PostDate = new DateTime(2019, 05, 29, 16, 23, 0) };
            Reply r41_2 = new Reply() { ApplicationUser = a2, Post = p41, Text = "Runtime polymorphism cannot be achieved without using inheritance.", PostDate = new DateTime(2019, 05, 29, 18, 14, 0) };
            Reply r41_3 = new Reply() { ApplicationUser = a3, Post = p41, Text = "Method overriding cannot be achieved without inheritance. By method overriding, we can give a specific implementation of some basic method contained by the base class.", PostDate = new DateTime(2019, 06, 30, 17, 18, 0) };

            Post p42 = new Post() { ApplicationUser = a13, Title = "Doubly fed induction generator (DFIG) ", Text = "How is the neutral point of the stator of a doubly fed induction generator (DFIG) connected??", PostDate = new DateTime(2019, 08, 12, 16, 0, 0), Tags = new List<Tag>() { tg3 } };
            Reply r42_1 = new Reply() { ApplicationUser = a4, Post = p42, Text = "If there is a difference between the three voltages, the best way for modelling is to make the transformation to Valfa, Vbeta and Vo. In this case Vo will be taken in consideration if the neutral is connected, other was it will be a floating voltage.", PostDate = new DateTime(2019, 08, 12, 16, 7, 0) };
            Reply r42_2 = new Reply() { ApplicationUser = a5, Post = p42, Text = "There is a difference between an autonomus induction generator and that connected to a grid. In this case the grid will impose the 3 voltages va, vb and vc..", PostDate = new DateTime(2019, 08, 12, 16, 14, 0) };
            Reply r42_3 = new Reply() { ApplicationUser = a1, Post = p42, Text = "There is a difference between an autonomus induction generator and that connected to a grid.", PostDate = new DateTime(2019, 08, 30, 17, 18, 0) };

            Post p43 = new Post() { ApplicationUser = a20, Title = "macro in Visual Basic .NET ", Text = "How to write a macro in Visual Basic .NET or in Visual Basic 2017 that automatically creates combobox a number of times??", PostDate = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg3 } };
            Reply r43_1 = new Reply() { ApplicationUser = a4, Post = p43, Text = "For i As Integer = 1 To Integer.Parse(TextBox1.Text)Dim tb As TextBoxtb = New TextBox()tb.Location = New Point(0, i * 30)tb.Text = i.ToString()Panel1.Controls.Add(tb).", PostDate = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r43_2 = new Reply() { ApplicationUser = a5, Post = p43, Text = "With TextBox1 as txtbox where the number of items is written and preferrably a button to handle the event and Panel1 as the target element.", PostDate = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r43_3 = new Reply() { ApplicationUser = a1, Post = p43, Text = "Remember to take into account that no event handlers have been defined for the added element yet.", PostDate = new DateTime(2019, 12, 30, 17, 18, 0) };

            Post p44 = new Post() { ApplicationUser = a7, Title = "Early Binding vs Late Binding", Text = "Hi,please somenone to explain me some things.Early Binding vs Late Binding Whats the differences?", PostDate = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg3 } };
            Reply r44_1 = new Reply() { ApplicationUser = a4, Post = p44, Text = "Early binding allows developers to interact with the object’s properties and methods during coding permits the compiler to check your code.Errors are caught at compile time.Early binding also results in faster codeEg : Dim ex as new Excel.Application", PostDate = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r44_2 = new Reply() { ApplicationUser = a5, Post = p44, Text = "Late binding on the other hand permits defining generic objects which may be bound to different objectsyou could declare myControl as Control without knowing which control you will encounter.", PostDate = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r44_3 = new Reply() { ApplicationUser = a1, Post = p44, Text = "You could query the Controls collection and determine which control you are working on using the TypeOf method and branch to the section of your code that provides for that type", PostDate = new DateTime(2019, 12, 30, 17, 18, 0) };


            Post p45 = new Post() { ApplicationUser = a8, Title = "Flexgrid and dbgrid control- Basic", Text = "Hello from me , I would like to make a question.If anybody could help me please.What is the differences between flexgrid and dbgrid control?", PostDate = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg3 } };
            Reply r45_1 = new Reply() { ApplicationUser = a4, Post = p45, Text = "Microsoft FlexGrid (MSFlexGrid) control displays and operates on tabular data", PostDate = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r45_2 = new Reply() { ApplicationUser = a5, Post = p45, Text = "Microsoft FlexGrid (MSFlexGrid) control displays and operates on tabular data. It allows programmatically sort, merge, and format tables containing strings and pictures.", PostDate = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r45_3 = new Reply() { ApplicationUser = a1, Post = p45, Text = "DBgrid is A spreadsheet-like bound control that displays a series of rows and columns representing records and fields from a ADO Recordset object.", PostDate = new DateTime(2019, 12, 30, 17, 18, 0) };

            // EDWWWWWWWWWWWWWW
            Post p86 = new Post() { ApplicationUser = a8, Title = "Angular", Text = "Hello from me , I would like to make a question.If anybody could help me please and explain me What is Angular??", PostDate = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg13,tg20 } };
            Reply r86_1 = new Reply() { ApplicationUser = a4, Post = p86, Text = "Angular is a TypeScript-based open-source web application framework.", PostDate = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r86_2 = new Reply() { ApplicationUser = a5, Post = p86, Text = "It offers an easy and powerful way of building front end web-based applications.", PostDate = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r86_3 = new Reply() { ApplicationUser = a1, Post = p86, Text = "Angular is a framework and integrates a range of features like declarative templates, dependency injection, end-to-end tooling, etc. that facilitates web application development.", PostDate = new DateTime(2019, 12, 30, 17, 18, 0) };
              
            Post p87 = new Post() { ApplicationUser = a9, Title = "Angular, Animation Support", Text = "Hi,please somenone to explain me some things.Does Angular support Animation???", PostDate = new DateTime(2019, 03, 11, 16, 0, 0), Tags = new List<Tag>() { tg20 } };
            Reply r87_1 = new Reply() { ApplicationUser = a5, Post = p87, Text = "Angular’s intuitive API allows the creation of high-performance, complex animation timelines with very little code..", PostDate = new DateTime(2019, 05, 12, 16, 7, 0) };
            Reply r87_2 = new Reply() { ApplicationUser = a8, Post = p87, Text = "Exactly what you said!!", PostDate = new DateTime(2019, 05, 12, 16, 7, 0) };









            Post p46 = new Post() { ApplicationUser = a9, Title = "Flexgrid and dbgrid control- Basic", Text = "Heeelllppp!Maybe my question , is a cap of tea for the most of you here.What is the differences between flexgrid and dbgrid control?", PostDate = DateTime.Now, Tags = new List<Tag>() { tg5, tg1 } };
            Post p47 = new Post() { ApplicationUser = a10, Title = "How Mvc works", Text = "What is Asp.Net MVC?", PostDate = DateTime.Now, Tags = new List<Tag>() { tg5 } };
            Post p48 = new Post() { ApplicationUser = a11, Title = "What is Library?", Text = "How can i import an library?", PostDate = DateTime.Now, Tags = new List<Tag>() { tg10 } };
            Post p49 = new Post() { ApplicationUser = a12, Title = "How many years i need to become programmer?", Text = "Will i ever become one?", PostDate = DateTime.Now, Tags = new List<Tag>() { tg12 } };
            Post p50 = new Post() { ApplicationUser = a13, Title = "What is a Dictionary ?", Text = "How can i use a Dictionary?", PostDate = DateTime.Now, Tags = new List<Tag>() { tg15 } };
            Post p51 = new Post() { ApplicationUser = a14, Title = "What SQL stands for?", Text = "Is it system quotation linear?", PostDate = DateTime.Now, Tags = new List<Tag>() { tg12, tg15 } };
            Post p52 = new Post() { ApplicationUser = a15, Title = "What can i achieve with seeding method?", Text = "How many hours i need for a seeding?", PostDate = DateTime.Now, Tags = new List<Tag>() { tg14 } };

            // *** ~~~ ~~~ ~~~ *** Admin's Post Replies *** ~~~ ~~~ ~~~ ***

            //This User(admin) is to test statistics view

            Post p53 = new Post() { ApplicationUser = admin, Title = "dummy1dummy1", Text = "dummy1dummy1", PostDate = new DateTime(2020, 1, 1), Tags = new List<Tag>() { tg11 } };
            Reply r53_1 = new Reply() { ApplicationUser = admin, Post = p53, Text = "This is a Dummy reply1", PostDate = new DateTime(2020, 2, 1) };
            Reply r53_2 = new Reply() { ApplicationUser = admin, Post = p53, Text = "This is a Dummy reply2", PostDate = new DateTime(2020, 2, 1) };
            Reply r53_3 = new Reply() { ApplicationUser = admin, Post = p53, Text = "This is a Dummy reply3", PostDate = new DateTime(2020, 3, 1) };
            Reply r53_4 = new Reply() { ApplicationUser = admin, Post = p53, Text = "This is a Dummy reply4", PostDate = new DateTime(2020, 3, 1) };
            Reply r53_5 = new Reply() { ApplicationUser = admin, Post = p53, Text = "This is a Dummy reply5", PostDate = new DateTime(2020, 3, 1) };
            Reply r53_6 = new Reply() { ApplicationUser = admin, Post = p53, Text = "This is a Dummy reply6", PostDate = new DateTime(2020, 3, 1) };
            Reply r53_7 = new Reply() { ApplicationUser = admin, Post = p53, Text = "This is a Dummy reply7", PostDate = new DateTime(2020, 4, 1) };
            Reply r53_8 = new Reply() { ApplicationUser = admin, Post = p53, Text = "This is a Dummy reply8", PostDate = new DateTime(2020, 4, 1) };

            Post p54 = new Post() { ApplicationUser = admin, Title = "dummy2dummy1", Text = "dummy2dummy1", PostDate = new DateTime(2020, 1, 1), Tags = new List<Tag>() { tg12 } };
            Reply r54_1 = new Reply() { ApplicationUser = admin, Post = p54, Text = "This is a Dummy replyjkkj1", PostDate = new DateTime(2020, 7, 1) };
            Reply r54_2 = new Reply() { ApplicationUser = admin, Post = p54, Text = "This is a Dummy replylkhlk2", PostDate = new DateTime(2020, 7, 1) };
            Reply r54_3 = new Reply() { ApplicationUser = admin, Post = p54, Text = "This is a Dummy reply;lh;l;lh3", PostDate = new DateTime(2020, 7, 1) };
            Reply r54_4 = new Reply() { ApplicationUser = admin, Post = p54, Text = "This is a Dummy repl'h;'hy4", PostDate = new DateTime(2020, 7, 1) };
            Reply r54_5 = new Reply() { ApplicationUser = admin, Post = p54, Text = "This is a Dummy repl;hl;lhy5", PostDate = new DateTime(2020, 7, 1) };
            Reply r54_6 = new Reply() { ApplicationUser = admin, Post = p54, Text = "This is a Dummy reph;l;hl;lly6", PostDate = new DateTime(2020, 12, 1) };
            Reply r54_7 = new Reply() { ApplicationUser = admin, Post = p54, Text = "This is a Dummy replyh;l;l;hl;l7", PostDate = new DateTime(2020, 12, 1) };
            Reply r54_8 = new Reply() { ApplicationUser = admin, Post = p54, Text = "This is a Dummy reh;l;lh;l;ply8", PostDate = new DateTime(2020, 12, 1) };

            Post p55 = new Post() { ApplicationUser = admin, Title = "dummy3dummy1", Text = "dummy3dummy1", PostDate = new DateTime(2020, 2, 1), Tags = new List<Tag>() { tg1 } };
            Reply r55_1 = new Reply() { ApplicationUser = admin, Post = p55, Text = "This is a Dummy reppply1", PostDate = new DateTime(2020, 9, 1) };
            Reply r55_2 = new Reply() { ApplicationUser = admin, Post = p55, Text = "This is a Dummy replppy2", PostDate = new DateTime(2020, 9, 1) };
            Reply r55_3 = new Reply() { ApplicationUser = admin, Post = p55, Text = "This is a Dummy replppy3", PostDate = new DateTime(2020, 9, 1) };
            Reply r55_4 = new Reply() { ApplicationUser = admin, Post = p55, Text = "This is a Dummy replpppy4", PostDate = new DateTime(2020, 8, 1) };
            Reply r55_5 = new Reply() { ApplicationUser = admin, Post = p55, Text = "This is a Dummy replppy5", PostDate = new DateTime(2020, 9, 1) };
            Reply r55_6 = new Reply() { ApplicationUser = admin, Post = p55, Text = "This is a Dummy replpppy6", PostDate = new DateTime(2020, 9, 1) };
            Reply r55_7 = new Reply() { ApplicationUser = admin, Post = p55, Text = "This is a Dummy replpppy7", PostDate = new DateTime(2020, 10, 1) };
            Reply r55_8 = new Reply() { ApplicationUser = admin, Post = p55, Text = "This is a Dummy replpppy8", PostDate = new DateTime(2020, 12, 1) };


            Post p56 = new Post() { ApplicationUser = admin, Title = "dummy4dummy1", Text = "dummy4dummy1", PostDate = new DateTime(2020, 2, 1), Tags = new List<Tag>() { tg2 } };
            Reply r56_1 = new Reply() { ApplicationUser = admin, Post = p56, Text = "This is a Dummy reppply11", PostDate = new DateTime(2020, 8, 1) };
            Reply r56_2 = new Reply() { ApplicationUser = admin, Post = p56, Text = "This is a Dummy replppy22", PostDate = new DateTime(2020, 8, 1) };
            Reply r56_3 = new Reply() { ApplicationUser = admin, Post = p56, Text = "This is a Dummy replppy23", PostDate = new DateTime(2020, 8, 1) };
            Reply r56_4 = new Reply() { ApplicationUser = admin, Post = p56, Text = "This is a Dummy replpppy25", PostDate = new DateTime(2020, 5, 1) };
            Reply r56_5 = new Reply() { ApplicationUser = admin, Post = p56, Text = "This is a Dummy replppy12", PostDate = new DateTime(2020, 5, 1) };
            Reply r56_6 = new Reply() { ApplicationUser = admin, Post = p56, Text = "This is a Dummy replpppy64", PostDate = new DateTime(2020, 5, 1) };
            Reply r56_7 = new Reply() { ApplicationUser = admin, Post = p56, Text = "This is a Dummy replpppy72", PostDate = new DateTime(2020, 5, 1) };
            Reply r56_8 = new Reply() { ApplicationUser = admin, Post = p56, Text = "This is a Dummy replpppy851", PostDate = new DateTime(2020, 5, 1) };

            Post p57 = new Post() { ApplicationUser = admin, Title = "dummy5dummy1", Text = "dummy5dummy1", PostDate = new DateTime(2020, 3, 1), Tags = new List<Tag>() { tg3 } };
            Reply r57_1 = new Reply() { ApplicationUser = admin, Post = p57, Text = "This is a Dummy reppply112", PostDate = new DateTime(2020, 7, 1) };
            Reply r57_2 = new Reply() { ApplicationUser = admin, Post = p57, Text = "This is a Dummy replppy24", PostDate = new DateTime(2020, 7, 1) };
            Reply r57_3 = new Reply() { ApplicationUser = admin, Post = p57, Text = "This is a Dummy replppy36", PostDate = new DateTime(2020, 7, 1) };
            Reply r57_4 = new Reply() { ApplicationUser = admin, Post = p57, Text = "This is a Dummy replpppy74", PostDate = new DateTime(2020, 2, 1) };
            Reply r57_5 = new Reply() { ApplicationUser = admin, Post = p57, Text = "This is a Dummy replppy85", PostDate = new DateTime(2020, 2, 1) };
            Reply r57_6 = new Reply() { ApplicationUser = admin, Post = p57, Text = "This is a Dummy replppp23y6", PostDate = new DateTime(2020, 2, 1) };
            Reply r57_7 = new Reply() { ApplicationUser = admin, Post = p57, Text = "This is a Dummy replppp23y7", PostDate = new DateTime(2020, 2, 1) };
            Reply r57_8 = new Reply() { ApplicationUser = admin, Post = p57, Text = "This is a Dummy replp2ppy8", PostDate = new DateTime(2020, 2, 1) };

            Post p58 = new Post() { ApplicationUser = admin, Title = "dummy6dummy1", Text = "dummy6dummy1", PostDate = new DateTime(2020, 4, 1), Tags = new List<Tag>() { tg9 } };
            Reply r58_1 = new Reply() { ApplicationUser = admin, Post = p58, Text = "This is a Dummy reppp23ly1", PostDate = new DateTime(2020, 6, 1) };
            Reply r58_2 = new Reply() { ApplicationUser = admin, Post = p58, Text = "This is a Dummy replpp42y2", PostDate = new DateTime(2020, 6, 1) };
            Reply r58_3 = new Reply() { ApplicationUser = admin, Post = p58, Text = "This is a Dummy replpp52y3", PostDate = new DateTime(2020, 6, 1) };
            Reply r58_4 = new Reply() { ApplicationUser = admin, Post = p58, Text = "This is a Dummy replpp2552py4", PostDate = new DateTime(2020, 6, 1) };
            Reply r58_5 = new Reply() { ApplicationUser = admin, Post = p58, Text = "This is a Dummy replp223py5", PostDate = new DateTime(2020, 4, 1) };
            Reply r58_6 = new Reply() { ApplicationUser = admin, Post = p58, Text = "This is a Dummy replppp232y6", PostDate = new DateTime(2020, 4, 1) };
            Reply r58_7 = new Reply() { ApplicationUser = admin, Post = p58, Text = "This is a Dummy replpp23py7", PostDate = new DateTime(2020, 4, 1) };
            Reply r58_8 = new Reply() { ApplicationUser = admin, Post = p58, Text = "This is a Dummy repl232pppy8", PostDate = new DateTime(2020, 4, 1) };

            Post p59 = new Post() { ApplicationUser = admin, Title = "dummy7dummy1", Text = "dummy7dummy1", PostDate = new DateTime(2020, 5, 1), Tags = new List<Tag>() { tg7 } };
            Reply r59_1 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy reppp424ly1", PostDate = new DateTime(2020, 8, 1) };
            Reply r59_2 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy rep52lppy2", PostDate = new DateTime(2020, 8, 1) };
            Reply r59_3 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy repl3232ppy3", PostDate = new DateTime(2020, 8, 1) };
            Reply r59_4 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy replppp5252y4", PostDate = new DateTime(2020, 11, 1) };
            Reply r59_5 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy rep23232lppy5", PostDate = new DateTime(2020, 11, 1) };
            Reply r59_6 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy replp52542ppy6", PostDate = new DateTime(2020, 11, 1) };
            Reply r59_7 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy replppp32323y7", PostDate = new DateTime(2020, 10, 1) };
            Reply r59_8 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy replpp2323py8", PostDate = new DateTime(2020, 12, 1) };
            Reply r59_9 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy replpp1232323py8", PostDate = new DateTime(2020, 10, 1) };
            Reply r59_10 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy repl23pp2323py8", PostDate = new DateTime(2020, 10, 1) };
            Reply r59_11 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy replpqwep2323py8", PostDate = new DateTime(2020, 10, 1) };
            Reply r59_12 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy replpqweqwp2323py8", PostDate = new DateTime(2020, 10, 1) };
            Reply r59_13 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy repqwelpp2323py8", PostDate = new DateTime(2020, 10, 1) };
            Reply r59_14 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy repl12312pp2323py8", PostDate = new DateTime(2020, 10, 1) };
            Reply r59_15 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy replqweqwpp2323py8", PostDate = new DateTime(2020, 10, 1) };
            Reply r59_16 = new Reply() { ApplicationUser = admin, Post = p59, Text = "This is a Dummy replqweqpp2323py8", PostDate = new DateTime(2020, 10, 1) };

            Post p60 = new Post() { ApplicationUser = admin, Title = "dummy8dummy1", Text = "dummy8dummy1", PostDate = new DateTime(2020, 5, 1), Tags = new List<Tag>() { tg10 } };
            Post p61 = new Post() { ApplicationUser = admin, Title = "dummy9dummy1", Text = "dummy9dummy1", PostDate = new DateTime(2020, 6, 1), Tags = new List<Tag>() { tg12 } };
            Post p62 = new Post() { ApplicationUser = admin, Title = "dummy10dummy1", Text = "dummy10dummy1", PostDate = new DateTime(2020, 7, 1), Tags = new List<Tag>() { tg13 } };
            Post p63 = new Post() { ApplicationUser = admin, Title = "dummy11dummy1", Text = "dummy11dummy1", PostDate = new DateTime(2020, 8, 1), Tags = new List<Tag>() { tg9 } };
            Post p64 = new Post() { ApplicationUser = admin, Title = "dummy12dummy1", Text = "dummy12dummy1", PostDate = new DateTime(2020, 9, 1), Tags = new List<Tag>() { tg1 } };
            Post p65 = new Post() { ApplicationUser = admin, Title = "dummy13dummy1", Text = "dummy13dummy1", PostDate = new DateTime(2020, 10, 1), Tags = new List<Tag>() { tg5 } };
            Post p66 = new Post() { ApplicationUser = admin, Title = "dummy14dummy1", Text = "dummy14dummy1", PostDate = new DateTime(2020, 11, 1), Tags = new List<Tag>() { tg6 } };
            Post p67 = new Post() { ApplicationUser = admin, Title = "dummy15dummy1", Text = "dummy15dummy1", PostDate = new DateTime(2020, 11, 1), Tags = new List<Tag>() { tg6 } };
            Post p68 = new Post() { ApplicationUser = admin, Title = "dummy16dummy1", Text = "dummy16dummy1", PostDate = new DateTime(2020, 11, 1), Tags = new List<Tag>() { tg6 } };
            Post p69 = new Post() { ApplicationUser = admin, Title = "dummy17dummy1", Text = "dummy17dummy1", PostDate = new DateTime(2020, 11, 1), Tags = new List<Tag>() { tg6 } };
            Post p70 = new Post() { ApplicationUser = admin, Title = "dummy18dummy1", Text = "dummy18dummy1", PostDate = new DateTime(2020, 11, 1), Tags = new List<Tag>() { tg6 } };
            Post p71 = new Post() { ApplicationUser = admin, Title = "dummy19dummy1", Text = "dummy19dummy1", PostDate = new DateTime(2020, 12, 1), Tags = new List<Tag>() { tg6 } };
            Post p72 = new Post() { ApplicationUser = admin, Title = "dummy20dummy1", Text = "dummy20dummy1", PostDate = new DateTime(2020, 12, 1), Tags = new List<Tag>() { tg6 } };
            Post p73 = new Post() { ApplicationUser = admin, Title = "dummy21dummy1", Text = "dummy21dummy1", PostDate = new DateTime(2020, 12, 1), Tags = new List<Tag>() { tg6 } };
            Post p74 = new Post() { ApplicationUser = admin, Title = "dummy22dummy1", Text = "dummy22dummy1", PostDate = new DateTime(2020, 12, 1), Tags = new List<Tag>() { tg6 } };
            Post p75 = new Post() { ApplicationUser = admin, Title = "dummy23dummy1", Text = "dummy23dummy1", PostDate = new DateTime(2020, 12, 1), Tags = new List<Tag>() { tg6 } };
            Post p76 = new Post() { ApplicationUser = admin, Title = "dummy24dummy1", Text = "dummy24dummy1", PostDate = new DateTime(2020, 12, 1), Tags = new List<Tag>() { tg6 } };
            Post p77 = new Post() { ApplicationUser = admin, Title = "dummy25dummy1", Text = "dummy25dummy1", PostDate = new DateTime(2020, 1, 1), Tags = new List<Tag>() { tg6 } };
            Post p78 = new Post() { ApplicationUser = admin, Title = "dummy26dummy1", Text = "dummy26dummy1", PostDate = new DateTime(2020, 1, 1), Tags = new List<Tag>() { tg6 } };
            Post p79 = new Post() { ApplicationUser = admin, Title = "dummy27dummy1", Text = "dummy27dummy1", PostDate = new DateTime(2020, 1, 1), Tags = new List<Tag>() { tg6 } };
            Post p80 = new Post() { ApplicationUser = admin, Title = "dummy28dummy1", Text = "dummy28dummy1", PostDate = new DateTime(2020, 1, 1), Tags = new List<Tag>() { tg6 } };
            Post p81 = new Post() { ApplicationUser = admin, Title = "dummy29dummy1", Text = "dummy29dummy1", PostDate = new DateTime(2020, 1, 1), Tags = new List<Tag>() { tg6 } };
            Post p82 = new Post() { ApplicationUser = admin, Title = "dummy30dummy1", Text = "dummy30dummy1", PostDate = new DateTime(2020, 1, 1), Tags = new List<Tag>() { tg6 } };
            Post p83 = new Post() { ApplicationUser = admin, Title = "dummy31dummy1", Text = "dummy31dummy1", PostDate = new DateTime(2020, 1, 1), Tags = new List<Tag>() { tg6 } };
            Post p84 = new Post() { ApplicationUser = admin, Title = "dummy32dummy1", Text = "dummy32dummy1", PostDate = new DateTime(2020, 1, 1), Tags = new List<Tag>() { tg6 } };


            // *** ~~~ ~~~ ~~~ *** Books *** ~~~ ~~~ ~~~ ***

            Book b1 = new Book() { BookAuthor = "Joseph Albahari", Title = "C# 7.0 in a Nutshell", Description = "When you have questions about C# 7.0 or the .NET CLR and its core Framework assemblies", Publisher = "O'Reilly Media", Pages = 133, ProductionDate = new DateTime(2001, 04, 09), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/4136Vv9FsvL._SX334_BO1,204,203,200_.jpg" };
            Book b2 = new Book() { BookAuthor = " Jon Duckett", Title = "HTML and CSS", Description = "Every day, more and more people want to learn some HTML and CSS.", Publisher = "Wiley & Sons", Pages = 300, ProductionDate = new DateTime(2008, 07, 25), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/31aX81I6vnL._SX351_BO1,204,203,200_.jpg" };
            Book b3 = new Book() { BookAuthor = "Eric Freeman", Title = "Head First JavaScript", Description = "This brain-friendly guide teaches you everything from JavaScript language", Publisher = "O'Reilly Media", Pages = 500, ProductionDate = new DateTime(2017, 04, 18), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51CEdROWHsL._SX430_BO1,204,203,200_.jpg" };
            Book b4 = new Book() { BookAuthor = "John Stone", Title = "The Definitive Guide", Description = "Since 1996, JavaScript: The Definitive Guide has been the bible for JavaScript ", Publisher = "O'Reilly Media", Pages = 100, ProductionDate = new DateTime(2016, 01, 31), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51lu4ArIFYL._SX379_BO1,204,203,200_.jpg" };
            Book b5 = new Book() { BookAuthor = " Jamie Chan", Title = "C# in One Day", Description = "Learn C# Fast and Learn It Well. Master C# Programming", Publisher = " Learn Coding", Pages = 150, ProductionDate = new DateTime(2012, 02, 29), PhotoUrl = "https://m.media-amazon.com/images/I/51f5Bsxh3PL.jpg" };
            Book b6 = new Book() { BookAuthor = "Mark J. Price", Title = "C# 8.0 and .NET Core", Description = "Learn the fundamentals, practical applications, and latest features of C# 8.0", Publisher = "Packt Publishing", Pages = 352, ProductionDate = new DateTime(2019, 07, 30), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51+AEbYTT8L._SX403_BO1,204,203,200_.jpg" };
            Book b7 = new Book() { BookAuthor = "Eric Mathes", Title = "Python Crash Course", Description = "Second edition of the best-selling Python book in the world", Publisher = "Starch Press", Pages = 464, ProductionDate = new DateTime(2008, 08, 01), PhotoUrl = "https://m.media-amazon.com/images/I/510-dE3N1PL.jpg" };
            Book b8 = new Book() { BookAuthor = "Marc Luiz", Title = "Learning Python", Description = "Get a comprehensive, in-depth introduction to the core Python language", Publisher = "O'Reilly Media", Pages = 416, ProductionDate = new DateTime(1994, 10, 30), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51ycFmfAeKL._SX379_BO1,204,203,200_.jpg" };
            Book b9 = new Book() { BookAuthor = "Alex Banks", Title = "Learning React", Description = "If you want to learn how to build efficient user interfaces with React", Publisher = "O'Reilly Media", Pages = 694, ProductionDate = new DateTime(2004, 10, 01), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51Q43WRXJzL._SX379_BO1,204,203,200_.jpg" };
            Book b10 = new Book() { BookAuthor = "Shyam Seshadri ", Title = "AngularJS ", Description = "If you want to get started with AngularJS, either as a side project, an additional tool", Publisher = "O'Reilly Media", Pages = 558, ProductionDate = new DateTime(1978, 02, 25), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51k7kUJV4SL._SX379_BO1,204,203,200_.jpg" };
            Book b11 = new Book() { BookAuthor = "Shannon Bradshaw", Title = "MongoDB", Description = "Manage your data with a system designed to support modern application development", Publisher = "O'Reilly Media", Pages = 458, ProductionDate = new DateTime(2018, 01, 10), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51n4OPvZiWL._SX379_BO1,204,203,200_.jpg" };
            Book b12 = new Book() { BookAuthor = "Mario Casciaro", Title = "Node.js Design Patterns", Description = "Get the best out of Node.js by mastering its most powerful components ", Publisher = "Packt Publishing", Pages = 921, ProductionDate = new DateTime(2010, 02, 05), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51sh-NP1KvL._SX403_BO1,204,203,200_.jpg" };
            Book b13 = new Book() { BookAuthor = "Zac Gordon ", Title = "React Explained", Description = "React Explained is a fun and enjoyable introduction to React", Publisher = "Payton", Pages = 558, ProductionDate = new DateTime(2012, 01, 01), PhotoUrl = "https://m.media-amazon.com/images/I/51PNQd7RIwL.jpg" };
            Book b14 = new Book() { BookAuthor = "Andrew Stellman", Title = "Learning Agile", Description = "Learning Agile is a comprehensive guide to the most popular agile methods", Publisher = "O'Reilly Media", Pages = 158, ProductionDate = new DateTime(2015, 06, 14), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51+ZzwZmdeL._SX379_BO1,204,203,200_.jpg" };
            Book b15 = new Book() { BookAuthor = "John Sonmez", Title = "Agile Practice Guide", Description = "Agile Practice Guide &ndash; First Edition has been developed as a resource", Publisher = "Project Management ", Pages = 908, ProductionDate = new DateTime(2015, 01, 16), PhotoUrl = "https://m.media-amazon.com/images/I/411kpmM64xL.jpg" };
            Book b16 = new Book() { BookAuthor = "David Gourley ", Title = "HTTP Definitive Guide", Description = "Behind every web transaction lies the Hypertext Transfer Protocol (HTTP)", Publisher = "O'Reilly Media", Pages = 102, ProductionDate = new DateTime(2004, 11, 01), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51kviR05FYL._SX379_BO1,204,203,200_.jpg" };
            Book b17 = new Book() { BookAuthor = "Charles Kozierok", Title = "The TCP/IP Guide", Description = "From Charles M. Kozierok, the creator of the highly regarded www.pcguide.com", Publisher = "Starch Press", Pages = 1621, ProductionDate = new DateTime(2000, 10, 11), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51adpTlV5KL._SX376_BO1,204,203,200_.jpg" };


            // *** ~~~ ~~~ ~~~ *** Tutorials *** ~~~ ~~~ ~~~ ***

            Tutorial tu1 = new Tutorial() { TutorialAuthor = "John Sonmez", Title = "Developer's Career Guide", Description = "John Sonmez discovered that technical knowledge alone isn't enough to break through", Duration = TimeSpan.FromMinutes(120), ProductionDate = new DateTime(2004, 06, 02), PhotoUrl = "https://m.media-amazon.com/images/I/51yr12gkjRL.jpg" };
            Tutorial tu2 = new Tutorial() { TutorialAuthor = "John Fields", Title = "Java SE 8 Oracle", Description = "A Programmer’s Guide to Java® SE 8 Oracle Certified Associate (OCA)", Duration = TimeSpan.FromMinutes(140), ProductionDate = new DateTime(2017, 01, 23), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51YpnXrssTL._SX376_BO1,204,203,200_.jpg" };
            Tutorial tu3 = new Tutorial() { TutorialAuthor = "Tushar Sharma", Title = "Oracle Certified Professional", Description = "This book is a comprehensive, step-by-step and one-stop guide for the Java SE 8", Duration = TimeSpan.FromMinutes(110), ProductionDate = new DateTime(2013, 01, 12), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/41S+dBGvo5L._SX348_BO1,204,203,200_.jpg" };
            Tutorial tu4 = new Tutorial() { TutorialAuthor = "Kathy Sierra ", Title = "SCJP Sun Certified", Description = "Publisher's Note: Products purchased from Third Party sellers are not guaranteed", Duration = TimeSpan.FromMinutes(90), ProductionDate = new DateTime(2009, 07, 17), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/517zra+Z7AL._SX387_BO1,204,203,200_.jpg" };
            Tutorial tu5 = new Tutorial() { TutorialAuthor = "Joshua Bloch", Title = "Effective Java", Description = "Java has changed dramatically since the previous edition of Effective Java", Duration = TimeSpan.FromMinutes(60), ProductionDate = new DateTime(2015, 03, 01), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/41JLgmt8MlL._SX402_BO1,204,203,200_.jpg" };
            Tutorial tu6 = new Tutorial() { TutorialAuthor = "Herbert Schildt", Title = "The Complete Reference", Description = "Learn the Java essentials for web development or any type of programming", Duration = TimeSpan.FromMinutes(160), ProductionDate = new DateTime(2018, 01, 01), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51upQmM9gjL._SX402_BO1,204,203,200_.jpg" };
            Tutorial tu7 = new Tutorial() { TutorialAuthor = "Brian Goetz", Title = "Java Concurrency", Description = "The concurrency features added to the Java platform in Java 5.0", Duration = TimeSpan.FromMinutes(190), ProductionDate = new DateTime(2012, 12, 12), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51ezEd0Lw6L._SX377_BO1,204,203,200_.jpg" };
            Tutorial tu8 = new Tutorial() { TutorialAuthor = "Hanumant Deshmukh", Title = "OCP Oracle Certified", Description = "How to become a master of OCP Oracle Certification", Duration = TimeSpan.FromMinutes(460), ProductionDate = new DateTime(2018, 03, 01), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51HLA+vXs8L._SX384_BO1,204,203,200_.jpg" };
            Tutorial tu9 = new Tutorial() { TutorialAuthor = "Benjamin Evans ", Title = "Java in a Nutshell", Description = "This updated edition of Java in a Nutshell not only helps experienced Java ", Duration = TimeSpan.FromMinutes(260), ProductionDate = new DateTime(2019, 01, 21), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51-nUy-cSWL._SX331_BO1,204,203,200_.jpg" };
            Tutorial tu10 = new Tutorial() { TutorialAuthor = "Patrick Niemeyer", Title = "Learning Java", Description = "book will guide you through the language features and APIs of Java 11", Duration = TimeSpan.FromMinutes(560), ProductionDate = new DateTime(2016, 02, 25), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51+JNFNyhYL._SX379_BO1,204,203,200_.jpg" };
            Tutorial tu11 = new Tutorial() { TutorialAuthor = "Paul Deitel ", Title = "Java 9 Programmers", Description = "Live-code approach to teaching programming and explores the Java® 9", Duration = TimeSpan.FromMinutes(660), ProductionDate = new DateTime(2017, 09, 11), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51J5BJhyC0L._SX380_BO1,204,203,200_.jpg" };
            Tutorial tu12 = new Tutorial() { TutorialAuthor = "Craig Walls", Title = "Spring in Action", Description = "Spring in Action, 5th Edition is the fully updated revision of Manning's", Duration = TimeSpan.FromMinutes(660), ProductionDate = new DateTime(2017, 10, 13), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/51xkEqwHOxL._SX397_BO1,204,203,200_.jpg" };
            Tutorial tu13 = new Tutorial() { TutorialAuthor = "Mario Fusco ", Title = "Java in Action", Description = "The release of Java 9 builds on what made Java 8 so exciting", Duration = TimeSpan.FromMinutes(160), ProductionDate = new DateTime(2020, 01, 19), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/41NmUGJh1UL._SX397_BO1,204,203,200_.jpg" };
            Tutorial tu14 = new Tutorial() { TutorialAuthor = "Robert C. Martin", Title = "Handbook of Agile", Description = "Even bad code can function. Bring a development organization to its knees", Duration = TimeSpan.FromMinutes(260), ProductionDate = new DateTime(2018, 11, 20), PhotoUrl = "https://images-na.ssl-images-amazon.com/images/I/41jEbK-jG+L._SX374_BO1,204,203,200_.jpg" };
            Tutorial tu15 = new Tutorial() { TutorialAuthor = "John Sonmez", Title = "Stop Being Lazy", Description = "You see, I learned how to overcome laziness and you can too", Duration = TimeSpan.FromMinutes(960), ProductionDate = new DateTime(2012, 06, 07), PhotoUrl = "https://m.media-amazon.com/images/I/51ZdOL47zbL.jpg" };
            Tutorial tu16 = new Tutorial() { TutorialAuthor = "Ferreira Filho", Title = "Computer Science Distilled", Description = "A walkthrough of computer science concepts you must know", Duration = TimeSpan.FromMinutes(460), ProductionDate = new DateTime(2017, 09, 16), PhotoUrl = "https://m.media-amazon.com/images/I/51Lb4J6645L.jpg" };
            Tutorial tu17 = new Tutorial() { TutorialAuthor = "Laakmann McDowell ", Title = "Cracking the Tech", Description = "Cracking the Tech Career is the job seeker's guide to landing a coveted position", Duration = TimeSpan.FromMinutes(760), ProductionDate = new DateTime(2020, 05, 29), PhotoUrl = "https://m.media-amazon.com/images/I/51kjWrvEvPL.jpg" };


            // *** ~~~ ~~~ ~~~ *** Customer's Orders *** ~~~ ~~~ ~~~ ***


            var o1 = new Order() { OrderDate = new DateTime(2020, 1, 1, 12, 02, 03) };
            var op1 = new OrderProduct() { Price = 15.12m, Product = tu1, Dummy = 1, Order = o1, Quantity = 2 };
            var op2 = new OrderProduct() { Price = 15.62m, Product = b1, Dummy = 2, Order = o1, Quantity = 6 };
            a1.Orders = new List<Order> { o1 };

            var o2 = new Order() { OrderDate = new DateTime(2020, 1, 1, 12, 12, 03) };
            var op3 = new OrderProduct() { Price = 12.32m, Product = b1, Dummy = 3, Order = o2, Quantity = 1 };
            var op4 = new OrderProduct() { Price = 17.22m, Product = tu3, Dummy = 4, Order = o2, Quantity = 3 };

            var o3 = new Order() { OrderDate = new DateTime(2020, 1, 2, 12, 02, 03) };
            var op5 = new OrderProduct() { Price = 12.32m, Product = b1, Dummy = 5, Order = o3, Quantity = 1 };
            var op6 = new OrderProduct() { Price = 17.22m, Product = tu3, Dummy = 6, Order = o3, Quantity = 1 };
            a2.Orders = new List<Order> { o2, o3 };

            var o4 = new Order() { OrderDate = new DateTime(2020, 1, 3, 12, 02, 03) };
            var op7 = new OrderProduct() { Price = 12.32m, Product = b1, Dummy = 7, Order = o4, Quantity = 3 };
            var op10 = new OrderProduct() { Price = 17.22m, Product = tu16, Dummy = 10, Order = o4, Quantity = 1 };
            a3.Orders = new List<Order> { o4 };

            var o5 = new Order() { OrderDate = new DateTime(2020, 1, 4, 12, 02, 03) };
            var op11 = new OrderProduct() { Price = 12.32m, Product = b6, Dummy = 11, Order = o5, Quantity = 1 };
            var op12 = new OrderProduct() { Price = 17.22m, Product = tu6, Dummy = 12, Order = o5, Quantity = 1 };
            a4.Orders = new List<Order> { o5 };

            var o6 = new Order() { OrderDate = new DateTime(2020, 1, 15, 23, 22, 03) };
            var op13 = new OrderProduct() { Price = 100.12m, Product = b5, Dummy = 13, Order = o6, Quantity = 3 };
            var op14 = new OrderProduct() { Price = 13.22m, Product = tu12, Dummy = 14, Order = o6, Quantity = 2 };
            a5.Orders = new List<Order> { o6 };

            var o7 = new Order() { OrderDate = new DateTime(2020, 5, 5, 12, 21, 00) };
            var op15 = new OrderProduct() { Price = 15.32m, Product = b3, Dummy = 15, Order = o7, Quantity = 1 };
            var op16 = new OrderProduct() { Price = 16.34m, Product = b1, Dummy = 16, Order = o7, Quantity = 2 };
            var op17 = new OrderProduct() { Price = 11.37m, Product = tu4, Dummy = 17, Order = o7, Quantity = 1 };
            var op18 = new OrderProduct() { Price = 5.72m, Product = b17, Dummy = 18, Order = o7, Quantity = 5 };
            var op19 = new OrderProduct() { Price = 2.92m, Product = tu17, Dummy = 19, Order = o7, Quantity = 1 };
            a6.Orders = new List<Order> { o7 };

            var o8 = new Order() { OrderDate = new DateTime(2020, 7, 15, 20, 12, 05) };
            var op20 = new OrderProduct() { Price = 10.00m, Product = b1, Dummy = 20, Order = o8, Quantity = 4 };
            var op21 = new OrderProduct() { Price = 05.25m, Product = tu7, Dummy = 21, Order = o8, Quantity = 5 };
            var op22 = new OrderProduct() { Price = 03.50m, Product = tu9, Dummy = 22, Order = o8, Quantity = 1 };
            var op23 = new OrderProduct() { Price = 100.00m, Product = b12, Dummy = 23, Order = o8, Quantity = 2 };
            var op24 = new OrderProduct() { Price = 5.00m, Product = b14, Dummy = 24, Order = o8, Quantity = 1 };
            a7.Orders = new List<Order> { o8 };

            var o9 = new Order() { OrderDate = new DateTime(2020, 2, 3, 10, 00, 00) };
            var op25 = new OrderProduct() { Price = 25.30m, Product = b2, Dummy = 25, Order = o9, Quantity = 4 };
            var op26 = new OrderProduct() { Price = 20.15m, Product = tu3, Dummy = 26, Order = o9, Quantity = 2 };
            var op27 = new OrderProduct() { Price = 15.10m, Product = tu4, Dummy = 27, Order = o9, Quantity = 1 };
            var op28 = new OrderProduct() { Price = 12.25m, Product = tu5, Dummy = 28, Order = o9, Quantity = 6 };

            var o10 = new Order() { OrderDate = new DateTime(2020, 2, 3, 10, 10, 00) };
            var op29 = new OrderProduct() { Price = 12.32m, Product = b4, Dummy = 29, Order = o10, Quantity = 1 };
            var op30 = new OrderProduct() { Price = 17.22m, Product = b6, Dummy = 30, Order = o10, Quantity = 1 };
            var op31 = new OrderProduct() { Price = 17.22m, Product = b8, Dummy = 31, Order = o10, Quantity = 1 };
            a8.Orders = new List<Order> { o9, o10 };

            var o11 = new Order() { OrderDate = new DateTime(2020, 2, 4, 15, 25, 00) };
            var op32 = new OrderProduct() { Price = 10.00m, Product = b4, Dummy = 32, Order = o11, Quantity = 3 };
            var op33 = new OrderProduct() { Price = 2.15m, Product = b8, Dummy = 33, Order = o11, Quantity = 4 };
            a9.Orders = new List<Order> { o11 };

            var o12 = new Order() { OrderDate = new DateTime(2020, 2, 4, 20, 00, 00) };
            var op34 = new OrderProduct() { Price = 15.00m, Product = tu1, Dummy = 34, Order = o12, Quantity = 1 };
            var op35 = new OrderProduct() { Price = 12.25m, Product = tu2, Dummy = 35, Order = o12, Quantity = 1 };
            a10.Orders = new List<Order> { o12 };

            var o13 = new Order() { OrderDate = new DateTime(2020, 2, 4, 21, 00, 00) };
            var op36 = new OrderProduct() { Price = 5.30m, Product = b1, Dummy = 36, Order = o13, Quantity = 2 };
            var op37 = new OrderProduct() { Price = 3.20m, Product = tu1, Dummy = 37, Order = o13, Quantity = 1 };
            a11.Orders = new List<Order> { o13 };

            var o14 = new Order() { OrderDate = new DateTime(2020, 4, 22, 12, 00, 43) };
            var op38 = new OrderProduct() { Price = 12.32m, Product = b7, Dummy = 38, Order = o14, Quantity = 1 };
            var op39 = new OrderProduct() { Price = 17.22m, Product = b9, Dummy = 39, Order = o14, Quantity = 1 };
            a12.Orders = new List<Order> { o14 };

            var o15 = new Order() { OrderDate = new DateTime(2020, 4, 23, 16, 00, 42) };
            var op40 = new OrderProduct() { Price = 25m, Product = b10, Dummy = 40, Order = o15, Quantity = 1 };
            var op41 = new OrderProduct() { Price = 24m, Product = tu10, Dummy = 41, Order = o15, Quantity = 1 };
            a13.Orders = new List<Order> { o15 };

            var o16 = new Order() { OrderDate = new DateTime(2020, 6, 25, 14, 00, 15) };
            var op42 = new OrderProduct() { Price = 55.00m, Product = b11, Dummy = 42, Order = o16, Quantity = 3 };
            var op43 = new OrderProduct() { Price = 105.00m, Product = tu11, Dummy = 43, Order = o16, Quantity = 3 };
            var op44 = new OrderProduct() { Price = 45.00m, Product = tu16, Dummy = 44, Order = o16, Quantity = 3 };
            a14.Orders = new List<Order> { o16 };

            var o17 = new Order() { OrderDate = new DateTime(2020, 6, 26, 07, 05, 23) };
            var op45 = new OrderProduct() { Price = 10m, Product = b10, Dummy = 45, Order = o17, Quantity = 2 };
            a15.Orders = new List<Order> { o17 };

            var o18 = new Order() { OrderDate = new DateTime(2020, 7, 25, 21, 00, 43) };
            var op46 = new OrderProduct() { Price = 11.59m, Product = tu3, Dummy = 46, Order = o18, Quantity = 1 };
            a16.Orders = new List<Order> { o18 };

            var o19 = new Order() { OrderDate = new DateTime(2020, 7, 26, 20, 15, 25) };
            var op47 = new OrderProduct() { Price = 5.00m, Product = b1, Dummy = 47, Order = o19, Quantity = 2 };
            var op48 = new OrderProduct() { Price = 2.25m, Product = b5, Dummy = 48, Order = o19, Quantity = 5 };
            var op49 = new OrderProduct() { Price = 1.99m, Product = b9, Dummy = 49, Order = o19, Quantity = 4 };
            var op50 = new OrderProduct() { Price = 5.25m, Product = tu9, Dummy = 50, Order = o19, Quantity = 1 };
            var op51 = new OrderProduct() { Price = 10m, Product = tu10, Dummy = 51, Order = o19, Quantity = 7 };
            var op52 = new OrderProduct() { Price = 3m, Product = tu11, Dummy = 52, Order = o19, Quantity = 2 };
            var op53 = new OrderProduct() { Price = 50m, Product = tu12, Dummy = 53, Order = o19, Quantity = 1 };
            a17.Orders = new List<Order> { o19 };

            var o20 = new Order() { OrderDate = new DateTime(2020, 10, 26, 20, 16, 30) };
            var op54 = new OrderProduct() { Price = 11.59m, Product = b12, Dummy = 54, Order = o20, Quantity = 1 };
            var op55 = new OrderProduct() { Price = 120.59m, Product = tu12, Dummy = 55, Order = o20, Quantity = 1 };
            var op56 = new OrderProduct() { Price = 13.59m, Product = tu16, Dummy = 56, Order = o20, Quantity = 1 };
            var op57 = new OrderProduct() { Price = 20m, Product = tu17, Dummy = 57, Order = o20, Quantity = 1 };
            a18.Orders = new List<Order> { o20 };

            var o21 = new Order() { OrderDate = new DateTime(2020, 11, 26, 20, 16, 30) };
            var op58 = new OrderProduct() { Price = 11.59m, Product = b12, Dummy = 58, Order = o21, Quantity = 1 };
            var op59 = new OrderProduct() { Price = 12.59m, Product = tu12, Dummy = 59, Order = o21, Quantity = 1 };
            var op60 = new OrderProduct() { Price = 180.59m, Product = tu16, Dummy = 60, Order = o21, Quantity = 1 };
            var op61 = new OrderProduct() { Price = 20m, Product = tu17, Dummy = 61, Order = o21, Quantity = 1 };
            a19.Orders = new List<Order> { o21 };

            var o22 = new Order() { OrderDate = new DateTime(2020, 12, 26, 20, 16, 30) };
            var op62 = new OrderProduct() { Price = 11.59m, Product = b12, Dummy = 62, Order = o22, Quantity = 1 };
            var op63 = new OrderProduct() { Price = 65.59m, Product = tu12, Dummy = 63, Order = o22, Quantity = 1 };
            var op64 = new OrderProduct() { Price = 13.59m, Product = tu16, Dummy = 64, Order = o22, Quantity = 1 };
            var op65 = new OrderProduct() { Price = 20m, Product = tu17, Dummy = 65, Order = o22, Quantity = 1 };
            a22.Orders = new List<Order> { o22 };

            var o23 = new Order() { OrderDate = new DateTime(2020, 3, 26, 20, 16, 30) };
            var op66 = new OrderProduct() { Price = 101.59m, Product = b12, Dummy = 66, Order = o23, Quantity = 1 };
            var op67 = new OrderProduct() { Price = 112.59m, Product = tu12, Dummy = 67, Order = o23, Quantity = 1 };
            var op68 = new OrderProduct() { Price = 13.59m, Product = tu16, Dummy = 68, Order = o23, Quantity = 1 };
            var op69 = new OrderProduct() { Price = 20m, Product = tu17, Dummy = 69, Order = o23, Quantity = 1 };
            a21.Orders = new List<Order> { o23 };

            var o24 = new Order() { OrderDate = new DateTime(2020, 1, 26, 20, 16, 30) };
            var op70 = new OrderProduct() { Price = 101.59m, Product = b14, Dummy = 70, Order = o24, Quantity = 1 };
            var op71 = new OrderProduct() { Price = 112.59m, Product = b9, Dummy = 71, Order = o24, Quantity = 1 };
            var op72 = new OrderProduct() { Price = 13.59m, Product = b2, Dummy = 72, Order = o24, Quantity = 1 };
            var op73 = new OrderProduct() { Price = 20m, Product = tu2, Dummy = 73, Order = o24, Quantity = 1 };
            a22.Orders = new List<Order> { o24 };

            var o25 = new Order() { OrderDate = new DateTime(2020, 8, 26, 20, 16, 30) };
            var op74 = new OrderProduct() { Price = 101.59m, Product = b12, Dummy = 74, Order = o25, Quantity = 1 };
            var op75 = new OrderProduct() { Price = 112.59m, Product = tu9, Dummy = 75, Order = o25, Quantity = 1 };
            var op76 = new OrderProduct() { Price = 13.59m, Product = tu1, Dummy = 76, Order = o25, Quantity = 1 };
            var op77 = new OrderProduct() { Price = 20m, Product = b15, Dummy = 77, Order = o25, Quantity = 1 };
            a25.Orders = new List<Order> { o25 };

            var o26 = new Order() { OrderDate = new DateTime(2020, 11, 26, 20, 16, 30) };
            var op78 = new OrderProduct() { Price = 101.59m, Product = b5, Dummy = 78, Order = o26, Quantity = 1 };
            var op79 = new OrderProduct() { Price = 12.59m, Product = tu5, Dummy = 79, Order = o26, Quantity = 1 };
            var op80 = new OrderProduct() { Price = 13.59m, Product = tu6, Dummy = 80, Order = o26, Quantity = 1 };
            var op81 = new OrderProduct() { Price = 20m, Product = tu7, Dummy = 81, Order = o26, Quantity = 1 };
            a26.Orders = new List<Order> { o26 };



            context.Users.AddOrUpdate(x => x.UserName, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10,
                a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21,
                a22, a23, a24, a25, a26, a27, a28, a29, a30);
            context.Tags.AddOrUpdate(x => x.Title, tg1, tg2, tg3, tg4, tg5, tg6, tg7, tg8, tg9, tg10, tg11, tg12, tg13, tg14, tg15, tg16, tg17, tg18, tg19, tg20);
            context.Posts.AddOrUpdate(x => x.Text, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10,
                p11, p12, p13, p14, p15, p16, p17, p18, p19, p20,
                p21, p22, p23, p24, p25, p26, p27, p28, p29, p30,
                p31, p32, p33, p34, p35, p36, p37, p38, p39, p40,
                p41, p42, p43, p44, p45, p46, p47, p48, p49, p50,
                p51, p52, p53, p54, p55, p56, p57, p58, p59, p60,
                p61, p62, p63, p64, p65, p66, p67, p68, p69, p70,
                p71, p72, p73, p74, p75, p76, p77, p78, p79, p80,
                p81, p82, p83, p84,p86,p87
                );
            context.Replies.AddOrUpdate(x => x.Text, r1_1, r1_2,
            r2_1, r2_2, r2_3,
            r3_1, r3_2, r3_3,
            r4_1, r4_2, r4_3,
            r5_1, r5_2, r5_3,
            r6_1, r6_2, r6_3,
            r7_1, r7_2, r7_3,
            r8_1, r8_2, r8_3, r8_4,
            r9_1, r9_2, r9_3, r9_4,
            r10_1, r10_2, r10_3,
            r11_1, r11_2, r11_3,
            r12_1, r12_2, r12_3,
            r13_1, r13_2, r13_3,
            r14_1, r14_2, r14_3,
            r15_1, r15_2, r15_3,
            r16_1, r16_2, r16_3,
            r17_1, r17_2, r17_3,
            r18_1, r18_2, r18_3,
            r19_1, r19_2, r19_3,
            r20_1, r20_2, r20_3,
            r21_1, r21_2, r21_3,
            r22_1, r22_2, r22_3,
            r23_1, r23_2, r23_3,
            r24_1, r24_2, r24_3, r24_4, r24_5, r24_6,
            r25_1, r25_2, r25_3,
            r26_1, r26_2, r26_3,
            r27_1, r27_2, r27_3,
            r28_1, r28_2, r28_3,
            r29_1, r29_2, r29_3,
            r30_1, r30_2, r30_3,
            r31_1, r31_2, r31_3,
            r32_1, r32_2, r32_3,
            r33_1, r33_2, r33_3,
            r34_1, r34_2, r34_3,
            r35_1, r35_2, r35_3,
            r36_1, r36_2, r36_3,
            r37_1, r37_2, r37_3,
            r38_1, r38_2, r38_3,
            r39_1, r39_2, r39_3,
            r40_1, r40_2, r40_3,
            r41_1, r41_2, r41_3,
            r42_1, r42_2, r42_3,
            r43_1, r43_2, r43_3,
            r44_1, r44_2, r44_3,
            r45_1, r45_2, r45_3,
            r53_1, r53_2, r53_3, r53_4, r53_5, r53_6, r53_7, r53_8,
            r54_1, r54_2, r54_3, r54_4, r54_5, r54_6, r54_7, r54_8,
            r55_1, r55_2, r55_3, r55_4, r55_5, r55_6, r55_7, r55_8,
            r56_1, r56_2, r56_3, r56_4, r56_5, r56_6, r56_7, r56_8,
            r57_1, r57_2, r57_3, r57_4, r57_5, r57_6, r57_7, r57_8,
            r58_1, r58_2, r58_3, r58_4, r58_5, r58_6, r58_7, r58_8,
            r59_1, r59_2, r59_3, r59_4, r59_5, r59_6, r59_7, r59_8, r59_9, r59_10, r59_11, r59_12, r59_13, r59_14, r59_15, r59_16,r86_1,r86_2,r86_3,r87_1,r87_2
            );
            context.Products.AddOrUpdate(x => x.Title, tu1, tu2, tu3, tu4, tu5, tu6, tu7, tu8, tu9, tu10,
                tu11, tu12, tu13, tu14, tu15, tu16, tu17,
                b1, b2, b3, b4, b5, b6, b7, b8, b9, b10,
                b11, b12, b13, b14, b15, b16, b17);
            context.Orders.AddOrUpdate(x => x.OrderDate, o1, o2, o3, o4, o5, o6, o7, o8, o9, o10,
                o11, o12, o13, o14, o15, o16, o17, o18, o19, o20,
                o21, o22, o23, o24, o25, o26
                );
            context.OrderProducts.AddOrUpdate(x => x.Dummy, op1, op2, op5, op6, op7, op10,
                op11, op12, op13, op14, op15, op16, op17, op18, op19, op20,
                op21, op22, op23, op24, op25, op26, op27, op28, op29, op30,
                op31, op32, op33, op34, op35, op36, op37, op38, op39, op40,
                op41, op42, op43, op44, op45, op46, op47, op48, op49, op50,
                op51, op52, op53, op54, op55, op56, op57, op58, op59, op60,
                op61, op62, op63, op64, op65, op66, op67, op68, op69, op70,
                op71, op72, op73, op74, op75, op76, op77, op78, op79, op80,
                op81
                );
            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }

            #endregion
        }
    }
}
