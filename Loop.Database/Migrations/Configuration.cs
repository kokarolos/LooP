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
<<<<<<< HEAD
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
=======
            #region Seeding
<<<<<<< HEAD

<<<<<<< HEAD
>>>>>>> Seeding updated
=======
            // CREATING USERS  
            ApplicationUser a1 = new ApplicationUser() { FirstName = "Maria", LastName = "Kalimeri", DateOfBirth = new DateTime(1993, 05, 27), UserName = "mkalimeri93!" };
            ApplicationUser a2 = new ApplicationUser() { FirstName = "Nikolaos", LastName = "Koromilakis", DateOfBirth = new DateTime(1980, 09, 18), UserName = "nkoromilakis80!" };
            ApplicationUser a3 = new ApplicationUser() { FirstName = "Konstantinos", LastName = "Peponakis", DateOfBirth = new DateTime(2001, 07, 23), UserName = "kpeponakis01!" };
            ApplicationUser a4 = new ApplicationUser() { FirstName = "Anna", LastName = "Karpouzaki", DateOfBirth = new DateTime(1999, 01, 31), UserName = "akarpouzaki96!" };
            ApplicationUser a5 = new ApplicationUser() { FirstName = "Pinelopi", LastName = "Portokalaki", DateOfBirth = new DateTime(1994, 05, 16), UserName = "pportokalaki98!" };
=======
            // *** ~~~ ~~~ ~~~ *** Locations *** ~~~ ~~~ ~~~ ***
            Location loc1 = new Location() { Latitude = 40.63342m, Longitude = 22.94188m };
            Location loc2 = new Location() { Latitude = 35.51421m, Longitude = 24.02157m };
            Location loc3 = new Location() { Latitude = 37.98406m, Longitude = 23.72602m };
            Location loc4 = new Location() { Latitude = 35.50667m, Longitude = 27.21009m };
            Location loc5 = new Location() { Latitude = 37.94477m, Longitude = 23.64358m };

            // *** ~~~ ~~~ ~~~ *** Users *** ~~~ ~~~ ~~~ *** 
            ApplicationUser a1 = new ApplicationUser() { FirstName = "Maria", LastName = "Kalimeri", DateOfBirth = new DateTime(1993, 05, 27), UserName = "mkalimeri93!", Location = loc1 };
            ApplicationUser a2 = new ApplicationUser() { FirstName = "Nikolaos", LastName = "Koromilakis", DateOfBirth = new DateTime(1980, 09, 18), UserName = "nkoromilakis80!" , Location = loc2 };
            ApplicationUser a3 = new ApplicationUser() { FirstName = "Konstantinos", LastName = "Peponakis", DateOfBirth = new DateTime(2001, 07, 23), UserName = "kpeponakis01!", Location = loc3 };
            ApplicationUser a4 = new ApplicationUser() { FirstName = "Anna", LastName = "Karpouzaki", DateOfBirth = new DateTime(1999, 01, 31), UserName = "akarpouzaki96!", Location = loc4 };
            ApplicationUser a5 = new ApplicationUser() { FirstName = "Pinelopi", LastName = "Portokalaki", DateOfBirth = new DateTime(1994, 05, 16), UserName = "pportokalaki98!", Location = loc5 };
>>>>>>> Rebase Conflicts Try
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

<<<<<<< HEAD
            // CREATING TAGS  
>>>>>>> Seeding Users-Posts-Replies-Books with real Info
=======
            // *** ~~~ ~~~ ~~~ *** Tags *** ~~~ ~~~ ~~~ ***
>>>>>>> Rebase Conflicts Try
            Tag tg1 = new Tag() { Title = "C#", Description = "C# is a modern all purpose programming language." };
            Tag tg2 = new Tag() { Title = "Javascript", Description = "Javascript is the de facto language of front end development." };
            Tag tg3 = new Tag() { Title = "Basic", Description = "Once a very popular first language." };
            Tag tg4 = new Tag() { Title = "C", Description = "C is a very fast and close to the system language." };
            Tag tg5 = new Tag() { Title = "C++", Description = "C++ added classes to the C language." };
            Tag tg6 = new Tag() { Title = "HTML", Description = "Hyper text markup language\'s main application is constructing web sites." };
            Tag tg7 = new Tag() { Title = "Python", Description = "Easier language to learn. Usefull at statistics" };
            Tag tg8 = new Tag() { Title = "Java", Description = "Very Usefull OOP Language." };

<<<<<<< HEAD
<<<<<<< HEAD
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

<<<<<<< HEAD
            // *** ~~~ ~~~ ~~~ *** Replies Per User *** ~~~ ~~~ ~~~ ***
            a1.Replies = new List<Reply>() { r3 };
            a2.Replies = new List<Reply>() { r1 };
            a4.Replies = new List<Reply>() { r4 };
            a5.Replies = new List<Reply>() { r2, r5 };
=======
            Post p3 = new Post() { ApplicationUser = a3, Title = "How to create a new context per every async", Text = "And actually this test is green", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
=======
            // CREATING POSTS AND REPLIES  
=======
            // *** ~~~ ~~~ ~~~ *** Posts *** ~~~ ~~~ ~~~ ***
>>>>>>> Rebase Conflicts Try
            Post p1 = new Post() { ApplicationUser = a1, Title = "Printing a string", Text = "I want to print a string multiple times at the console using C#", DateTime = new DateTime(2019, 06, 18, 7, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r1_1 = new Reply() { ApplicationUser = a2, Post = p1, Text = "Use the Console.WriteLine function!", DateTime = new DateTime(2019, 06, 18, 7, 15, 0) };
            Reply r1_2 = new Reply() { ApplicationUser = a5, Post = p1, Text = "Use the for statement combined with Console.WriteLine!", DateTime = new DateTime(2019, 06, 18, 7, 30, 0) };

            Post p2 = new Post() { ApplicationUser = a2, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r2_1 = new Reply() { ApplicationUser = a1, Post = p2, Text = "One solution is to select by id, using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r2_2 = new Reply() { ApplicationUser = a4, Post = p2, Text = "You may also use querySelector, for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r2_3 = new Reply() { ApplicationUser = a5, Post = p2, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p3 = new Post() { ApplicationUser = a3, Title = "How to create a new context per every async", Text = "And actually this test is green", DateTime = new DateTime(2019, 06, 18, 7, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r3_1 = new Reply() { ApplicationUser = a1, Post = p3, Text = "What do you mean by create a stack of scopes, per every new async operation? If you have methodA calls methodB, and both are async methods, do you mean you want to create two scopes one for each?", DateTime = new DateTime(2019, 06, 18, 7, 15, 0) };
            Reply r3_2 = new Reply() { ApplicationUser = a2, Post = p3, Text = "You can also use querySelector, for css selectors", DateTime = new DateTime(2019, 06, 18, 7, 30, 0) };
            Reply r3_3 = new Reply() { ApplicationUser = a5, Post = p3, Text = "There is querySelectorAll", DateTime = new DateTime(2019, 06, 18, 7, 35, 0) };
>>>>>>> Seeding Users-Posts-Replies-Books with real Info

            Post p4 = new Post() { ApplicationUser = a4, Title = "Top 52 C# Interview Questions & Answers", Text = "What is C#?", DateTime = new DateTime(2019, 01, 20, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r4_1 = new Reply() { ApplicationUser = a2, Post = p4, Text = "C# is an object-oriented, type-safe, and managed language that is compiled by .Net framework to generate Microsoft Intermediate Language.", DateTime = new DateTime(2019, 01, 20, 16, 7, 0) };
            Reply r4_2 = new Reply() { ApplicationUser = a3, Post = p4, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 01, 21, 16, 17, 0) };
            Reply r4_3 = new Reply() { ApplicationUser = a7, Post = p4, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 01, 21, 17, 18, 0) };

            Post p5 = new Post() { ApplicationUser = a5, Title = "Boxing and Unboxing", Text = "What is Boxing and Unboxing in C#", DateTime = new DateTime(2019, 02, 28, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r5_1 = new Reply() { ApplicationUser = a1, Post = p5, Text = "Boxing and Unboxing both are used for type conversions.", DateTime = new DateTime(2019, 02, 28, 19, 7, 0) };
            Reply r5_2 = new Reply() { ApplicationUser = a2, Post = p5, Text = "The process of converting from a value type to a reference type is called boxing.", DateTime = new DateTime(2019, 03, 27, 12, 14, 0) };
            Reply r5_3 = new Reply() { ApplicationUser = a3, Post = p5, Text = "The process of converting from a reference type to a value type is called unboxing. Here is an example of unboxing in C#.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p6 = new Post() { ApplicationUser = a5, Title = "struct and class in C#", Text = "What is the difference between a struct and a class in C#?", DateTime = new DateTime(2019, 04, 28, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r6_1 = new Reply() { ApplicationUser = a3, Post = p6, Text = "The struct is a value type in C# and it inherits from System.Value Type.Struct is usually used for smaller amounts of data.The class is a reference type in C# and it inherits from the System.Object Type", DateTime = new DateTime(2019, 04, 28, 16, 7, 0) };
            Reply r6_2 = new Reply() { ApplicationUser = a1, Post = p6, Text = "Struct can’t be inherited from other types.A structure can't be abstract", DateTime = new DateTime(2019, 04, 28, 16, 14, 0) };
            Reply r6_3 = new Reply() { ApplicationUser = a15, Post = p6, Text = "A class can be an abstract type.Classes can be inherited from other classes", DateTime = new DateTime(2019, 04, 28, 17, 18, 0) };

            Post p7 = new Post() { ApplicationUser = a9, Title = "Interface and Abstract Class in C#", Text = "What is the difference between Interface and Abstract Class in C#?", DateTime = new DateTime(2019, 11, 24, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r7_1 = new Reply() { ApplicationUser = a2, Post = p7, Text = "A class can implement any number of interfaces but a subclass can at most use only one abstract class.An abstract class can have non-abstract methods(concrete methods) while in case of interface, all the methods have to be abstract.", DateTime = new DateTime(2019, 11, 25, 16, 9, 0) };
            Reply r7_2 = new Reply() { ApplicationUser = a3, Post = p7, Text = "An abstract class can declare or use any variables while an interface is not allowed to do so.In an abstract class, all data members or functions are private by default while in an interface all are public, we can’t change them manually.", DateTime = new DateTime(2019, 11, 25, 16, 14, 0) };
            Reply r7_3 = new Reply() { ApplicationUser = a5, Post = p7, Text = "In an abstract class, we need to use abstract keywords to declare abstract methods, while in an interface we don’t need to use that.", DateTime = new DateTime(2019, 11, 26, 18, 18, 0) };

            Post p8 = new Post() { ApplicationUser = a10, Title = "Enum in C#", Text = "What is enum in C#?", DateTime = new DateTime(2019, 07, 28, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r8_1 = new Reply() { ApplicationUser = a1, Post = p8, Text = "An enum is a value type with a set of related named constants often referred to as an enumerator list. The enum keyword is used to declare an enumeration. It is a primitive data type that is user-defined.", DateTime = new DateTime(2019, 07, 28, 16, 7, 0) };
            Reply r8_2 = new Reply() { ApplicationUser = a4, Post = p8, Text = "An enum type can be an integer (float, int, byte, double, etc.). But if you use it beside int it has to be cast.", DateTime = new DateTime(2019, 07, 28, 16, 14, 0) };
            Reply r8_3 = new Reply() { ApplicationUser = a2, Post = p8, Text = "An enum is used to create numeric constants in the .NET framework. All the members of enum are enum type. There must be a numeric value for each enum type.", DateTime = new DateTime(2019, 07, 28, 17, 18, 0) };

            Post p9 = new Post() { ApplicationUser = a11, Title = "Continue and Break statements", Text = "Whats the diffence of Continue and Break statements", DateTime = new DateTime(2019, 02, 15, 16, 0, 0), Tags = new List<Tag>() { tg1, tg4, tg5 } };
            Reply r9_1 = new Reply() { ApplicationUser = a1, Post = p9, Text = "Using break statement, you can 'jump out of a loop' whereas by using a continue statement, you can 'jump over one iteration' and then resume your loop execution", DateTime = new DateTime(2019, 02, 15, 16, 7, 0) };
            Reply r9_2 = new Reply() { ApplicationUser = a4, Post = p9, Text = "The continue statement passes control to the next iteration", DateTime = new DateTime(2019, 02, 15, 16, 14, 0) };
            Reply r9_3 = new Reply() { ApplicationUser = a3, Post = p9, Text = " you can 'jump over one iteration' and then resume your loop execution", DateTime = new DateTime(2019, 02, 15, 17, 18, 0) };

            Post p10 = new Post() { ApplicationUser = a11, Title = "Constant and readonly in C#", Text = "What is the difference between constant and readonly in C#?", DateTime = new DateTime(2019, 12, 28, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r10_1 = new Reply() { ApplicationUser = a1, Post = p10, Text = "Const is nothing but constant, a variable of which the value is constant but at compile time.", DateTime = new DateTime(2019, 12, 18, 17, 7, 0) };
            Reply r10_2 = new Reply() { ApplicationUser = a4, Post = p10, Text = "By default, a const is static and we cannot change the value of a const variable throughout the entire program.", DateTime = new DateTime(2019, 12, 28, 18, 14, 0) };
            Reply r10_3 = new Reply() { ApplicationUser = a2, Post = p10, Text = "Readonly is the keyword whose value we can change during runtime or we can assign it at run time but only through the non-static constructor.", DateTime = new DateTime(2019, 12, 28, 20, 14, 0) };

            Post p11 = new Post() { ApplicationUser = a12, Title = "Ref and out keywords", Text = "What is the difference between ref and out keywords?", DateTime = new DateTime(2019, 05, 29, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r11_1 = new Reply() { ApplicationUser = a1, Post = p11, Text = "The ref keyword passes arguments by reference. It means any changes made to this argument in the method will be reflected in that variable when control returns to the calling method.", DateTime = new DateTime(2019, 05, 29, 16, 23, 0) };
            Reply r11_2 = new Reply() { ApplicationUser = a2, Post = p11, Text = "The out keyword passes arguments by reference. This is very similar to the ref keyword.", DateTime = new DateTime(2019, 05, 29, 18, 14, 0) };
            Reply r11_3 = new Reply() { ApplicationUser = a3, Post = p11, Text = "Both ref and out are treated differently at run time and they are treated the same at compile time, so methods cannot be overloaded if one method takes an argument as ref and the other takes an argument as an out.", DateTime = new DateTime(2019, 06, 30, 17, 18, 0) };

            Post p12 = new Post() { ApplicationUser = a13, Title = "'This' keyword with static Methods C# ", Text = "Can 'this' be used within a static method?", DateTime = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r12_1 = new Reply() { ApplicationUser = a4, Post = p12, Text = "We can't use 'this' in a static method because the keyword 'this' returns a reference to the current instance of the class containing it.", DateTime = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r12_2 = new Reply() { ApplicationUser = a5, Post = p12, Text = "Static methods (or any static member) do not belong to a particular instance. They exist without creating an instance of the class and are called with the name of a class, not by instance, so we can’t use this keyword in the body of static Methods.", DateTime = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r12_3 = new Reply() { ApplicationUser = a1, Post = p12, Text = "The 'this' keyword in C# is a special type of reference variable that is implicitly defined within each constructor and non-static method as a first parameter of the type class in which it is defined.", DateTime = new DateTime(2019, 12, 30, 17, 18, 0) };

            Post p13 = new Post() { ApplicationUser = a14, Title = "Comments in HTML", Text = "How can I insert a comment in HTML?", DateTime = new DateTime(2019, 06, 30, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r13_1 = new Reply() { ApplicationUser = a1, Post = p13, Text = "Comments in HTML begins with <!–ends with–>.", DateTime = new DateTime(2019, 06, 30, 16, 7, 0) };
            Reply r13_2 = new Reply() { ApplicationUser = a8, Post = p13, Text = "<!--/-->That is exactly!", DateTime = new DateTime(2019, 06, 30, 16, 14, 0) };
            Reply r13_3 = new Reply() { ApplicationUser = a5, Post = p13, Text = "<!-- A SAMPLE COMMENT -->", DateTime = new DateTime(2019, 06, 30, 17, 19, 0) };

            Post p14 = new Post() { ApplicationUser = a15, Title = "Image map", Text = "What is an image map?", DateTime = new DateTime(2019, 01, 12, 16, 0, 0), Tags = new List<Tag>() { tg6 } };
            Reply r14_1 = new Reply() { ApplicationUser = a1, Post = p14, Text = "Image map lets you link to many different web pages using a single image.", DateTime = new DateTime(2019, 01, 12, 16, 7, 0) };
            Reply r14_2 = new Reply() { ApplicationUser = a4, Post = p14, Text = "You can define shapes in images that you want to make part of an image mapping.", DateTime = new DateTime(2019, 01, 12, 16, 14, 0) };
            Reply r14_3 = new Reply() { ApplicationUser = a1, Post = p14, Text = "You also define shapes in images ", DateTime = new DateTime(2019, 01, 12, 17, 18, 0) };

            Post p15 = new Post() { ApplicationUser = a16, Title = "Collapsing white space", Text = "What is the advantage of collapsing white space?", DateTime = new DateTime(2019, 03, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r15_1 = new Reply() { ApplicationUser = a1, Post = p15, Text = "White spaces are a blank sequence of space characters, which is treated as a single space character in HTML.", DateTime = new DateTime(2019, 03, 30, 16, 7, 0) };
            Reply r15_2 = new Reply() { ApplicationUser = a14, Post = p15, Text = "Because the browser collapses multiple spaces into a single space, you can indent lines of text without worrying about multiple spaces.", DateTime = new DateTime(2019, 03, 30, 16, 14, 0) };
            Reply r15_3 = new Reply() { ApplicationUser = a18, Post = p15, Text = "This enables you to organize the HTML code into a much more readable format.", DateTime = new DateTime(2019, 03, 30, 18, 18, 0) };

            Post p16 = new Post() { ApplicationUser = a17, Title = "Properties in C#", Text = "What are Properties in C#?", DateTime = new DateTime(2019, 02, 25, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r16_1 = new Reply() { ApplicationUser = a19, Post = p16, Text = "C# properties are members of a C# class that provide a flexible mechanism to read", DateTime = new DateTime(2019, 02, 25, 16, 7, 0) };
            Reply r16_2 = new Reply() { ApplicationUser = a6, Post = p16, Text = "C# properties use get and set methods, also known as accessors, to access and assign values to private fields.", DateTime = new DateTime(2019, 02, 25, 16, 17, 0) };
            Reply r16_3 = new Reply() { ApplicationUser = a5, Post = p16, Text = "Properties in C# are always public data members.", DateTime = new DateTime(2019, 02, 25, 17, 21, 0) };

            Post p17 = new Post() { ApplicationUser = a18, Title = "Extensions Methods", Text = "What are extension methods in C#?", DateTime = new DateTime(2019, 03, 12, 17, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r17_1 = new Reply() { ApplicationUser = a19, Post = p17, Text = "Extension methods enable you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. ", DateTime = new DateTime(2019, 03, 12, 18, 7, 0) };
            Reply r17_2 = new Reply() { ApplicationUser = a14, Post = p17, Text = "An extension method is a special kind of static method, but they are called as if they were instance methods on the extended type.", DateTime = new DateTime(2019, 03, 12, 19, 14, 0) };
            Reply r17_3 = new Reply() { ApplicationUser = a2, Post = p17, Text = "An extension method is a static method of a static class, where the 'this' modifier is applied to the first parameter. The type of the first parameter will be the type that is extended.", DateTime = new DateTime(2019, 03, 12, 20, 18, 0) };

            Post p18 = new Post() { ApplicationUser = a19, Title = "Dispose and finalize methods in C#?", Text = "What is the difference between the dispose and finalize methods in C#?", DateTime = new DateTime(2019, 01, 23, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r18_1 = new Reply() { ApplicationUser = a7, Post = p18, Text = "In finalize and dispose, both methods are used to free unmanaged resources.", DateTime = new DateTime(2019, 01, 23, 17, 8, 0) };
            Reply r18_2 = new Reply() { ApplicationUser = a4, Post = p18, Text = "Finalize is used to free unmanaged resources that are not in use, like files, database connections in the application domain and more. These are resources held by an object before that object is destroyed.", DateTime = new DateTime(2019, 01, 23, 19, 14, 0) };
            Reply r18_3 = new Reply() { ApplicationUser = a20, Post = p18, Text = "In the Internal process, it is called by Garbage Collector and can’t be called manual by user code or any service.", DateTime = new DateTime(2019, 01, 23, 20, 18, 0) };

            Post p19 = new Post() { ApplicationUser = a20, Title = "String and StringBuilder in C#", Text = "What is the difference between String and StringBuilder in C#?", DateTime = new DateTime(2019, 02, 13, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r19_1 = new Reply() { ApplicationUser = a1, Post = p19, Text = "StringBuilder and string are both used to string values, but both have many differences on the bases of instance creation and also in performance.", DateTime = new DateTime(2019, 02, 13, 16, 7, 0) };
            Reply r19_2 = new Reply() { ApplicationUser = a8, Post = p19, Text = "A string is an immutable object. Immutable is when we create string objects in code so we cannot modify or change that object in any operations like insert new value, replace or append any value with the existing value in a string object.", DateTime = new DateTime(2019, 02, 13, 16, 14, 0) };
            Reply r19_3 = new Reply() { ApplicationUser = a10, Post = p19, Text = "System.Text.Stringbuilder is a mutable object which also holds the string value, mutable means once we create a System.Text.Stringbuilder object. ", DateTime = new DateTime(2019, 02, 13, 17, 18, 0) };

            Post p20 = new Post() { ApplicationUser = a16, Title = "Delegates in C# and the uses of delegates", Text = "What are delegates?", DateTime = new DateTime(2019, 05, 27, 10, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r20_1 = new Reply() { ApplicationUser = a18, Post = p20, Text = "A Delegate is an abstraction of one or more function pointers", DateTime = new DateTime(2019, 05, 28, 16, 7, 0) };
            Reply r20_2 = new Reply() { ApplicationUser = a17, Post = p20, Text = "Delegates are derived from the System.MulticastDelegate class.They have a signature and a return type.A function that is added to delegates must be compatible with this signature.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r20_3 = new Reply() { ApplicationUser = a5, Post = p20, Text = "Delegates can point to either static or instance methods", DateTime = new DateTime(2019, 05, 29, 20, 18, 0) };

            Post p21 = new Post() { ApplicationUser = a18, Title = "Bootstrap colummns ", Text = "How can I make columns all the same height?I dont think i need any CSS , so i would like to do that with Bootstrap", DateTime = new DateTime(2019, 08, 29, 13, 0, 0), Tags = new List<Tag>() { tg6 } };
            Reply r21_1 = new Reply() { ApplicationUser = a2, Post = p21, Text = "Bootstrap 4 uses Flexbox so there is no need for extra CSS ", DateTime = new DateTime(2019, 08, 30, 16, 7, 0) };
            Reply r21_2 = new Reply() { ApplicationUser = a11, Post = p21, Text = "To only apply the same height flexbox at specific breakpoints (responsive), use a media query.", DateTime = new DateTime(2019, 08, 30, 16, 14, 0) };
            Reply r21_3 = new Reply() { ApplicationUser = a12, Post = p21, Text = "Flexbox is now used by default in Bootstrap 4 so there is no need for the extra CSS to make equal height columns:", DateTime = new DateTime(2019, 08, 30, 19, 18, 0) };

            Post p22 = new Post() { ApplicationUser = a12, Title = "Delegates C#", Text = "Why Do We Need Delegates?", DateTime = new DateTime(2019, 04, 12, 17, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r22_1 = new Reply() { ApplicationUser = a1, Post = p22, Text = "A delegate is a solution for situations in which you want to pass methods around to other methods.", DateTime = new DateTime(2019, 07, 12, 18, 7, 0) };
            Reply r22_2 = new Reply() { ApplicationUser = a8, Post = p22, Text = "You are so accustomed to passing data to methods as parameters that the idea of passing methods as an argument instead of data might sound a little strange.", DateTime = new DateTime(2019, 04, 12, 19, 14, 0) };
            Reply r22_3 = new Reply() { ApplicationUser = a7, Post = p22, Text = "The parameters of the method.The address of the method it calls.The return type of the method.", DateTime = new DateTime(2019, 04, 12, 21, 18, 0) };

            Post p23 = new Post() { ApplicationUser = a3, Title = "Sealed classes C#", Text = "What are sealed classes in C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r23_1 = new Reply() { ApplicationUser = a1, Post = p23, Text = "Sealed classes are used to restrict the inheritance feature of object-oriented programming.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
<<<<<<< HEAD
            Reply r23_2 = new Reply() { ApplicationUser = a4, Post = p23, Text = "Once a class is defined as a sealed class, the class cannot be inherited. ", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r23_3 = new Reply() { ApplicationUser = a5, Post = p23, Text = "In C#, the sealed modifier is used to define a class as sealed. In Visual Basic .NET the Not Inheritable keyword serves the purpose of the sealed class.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  WORKING ON
            Post p24 = new Post() { ApplicationUser = a3, Title = "What is IEnumerable<> in C#?", Text = "Could someone explain me when to use Ienumerable?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r24_1 = new Reply() { ApplicationUser = a1, Post = p24, Text = "IEnumerable is the parent interface for all non-generic collections in System.Collections namespace like ArrayList, HastTable etc. that can be enumerated", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r24_2 = new Reply() { ApplicationUser = a1, Post = p24, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r24_3 = new Reply() { ApplicationUser = a4, Post = p24, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r24_4 = new Reply() { ApplicationUser = a4, Post = p24, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r24_5 = new Reply() { ApplicationUser = a5, Post = p24, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };
            Reply r24_6 = new Reply() { ApplicationUser = a5, Post = p24, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p25 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r25_1 = new Reply() { ApplicationUser = a1, Post = p25, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r25_2 = new Reply() { ApplicationUser = a4, Post = p25, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r25_3 = new Reply() { ApplicationUser = a5, Post = p25, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p26 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r26_1 = new Reply() { ApplicationUser = a1, Post = p26, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r26_2 = new Reply() { ApplicationUser = a4, Post = p26, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r26_3 = new Reply() { ApplicationUser = a5, Post = p26, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p27 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r27_1 = new Reply() { ApplicationUser = a1, Post = p27, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r27_2 = new Reply() { ApplicationUser = a4, Post = p27, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r27_3 = new Reply() { ApplicationUser = a5, Post = p27, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p28 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r28_1 = new Reply() { ApplicationUser = a1, Post = p28, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r28_2 = new Reply() { ApplicationUser = a4, Post = p28, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r28_3 = new Reply() { ApplicationUser = a5, Post = p28, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

>>>>>>> Seeding Updated,Post Controller Updated


            // *** ~~~ ~~~ ~~~ *** Books *** ~~~ ~~~ ~~~ ***
=======
            Reply r23_2 = new Reply() { ApplicationUser = a14, Post = p23, Text = "Once a class is defined as a sealed class, the class cannot be inherited. ", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r23_3 = new Reply() { ApplicationUser = a15, Post = p23, Text = "In C#, the sealed modifier is used to define a class as sealed. In Visual Basic .NET the Not Inheritable keyword serves the purpose of the sealed class.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p24 = new Post() { ApplicationUser = a20, Title = "What is IEnumerable<> in C#?", Text = "Could someone explain me when to use Ienumerable?", DateTime = new DateTime(2019, 08, 29, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r24_1 = new Reply() { ApplicationUser = a12, Post = p24, Text = "IEnumerable is the parent interface for all non-generic collections in System.Collections namespace like ArrayList, HastTable etc. that can be enumerated", DateTime = new DateTime(2019, 08, 29, 16, 7, 0) };
            Reply r24_2 = new Reply() { ApplicationUser = a13, Post = p24, Text = "Enumerable in C# is an interface that defines one method, GetEnumerator which returns an IEnumerator interface. This allows readonly access to a collection then a collection that implements IEnumerable can be used with a for-each statement.", DateTime = new DateTime(2019, 08, 29, 17, 8, 0) };
            Reply r24_3 = new Reply() { ApplicationUser = a4, Post = p24, Text = "IEnumerable interface is a generic interface which allows looping over generic or non-generic lists.", DateTime = new DateTime(2019, 08, 29, 18, 14, 0) };
            Reply r24_4 = new Reply() { ApplicationUser = a14, Post = p24, Text = "IEnumerable interface also works with linq query expression.", DateTime = new DateTime(2019, 08, 29, 19, 15, 0) };
            Reply r24_5 = new Reply() { ApplicationUser = a15, Post = p24, Text = "IEnumerable interface Returns an enumerator that iterates through the collection.", DateTime = new DateTime(2019, 08, 30, 17, 18, 0) };
            Reply r24_6 = new Reply() { ApplicationUser = a5, Post = p24, Text = "IEnumerator is an interface which helps to get current elements from the collection, it has the following two methods", DateTime = new DateTime(2019, 08, 30, 18, 18, 0) };

            Post p25 = new Post() { ApplicationUser = a5, Title = "key features of Python", Text = "What are the key features of Python?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg7 } };
            Reply r25_1 = new Reply() { ApplicationUser = a2, Post = p25, Text = "Python is an interpreted language. That means that, unlike languages like C and its variants, Python does not need to be compiled before it is run. Other interpreted languages include PHP and Ruby.", DateTime = new DateTime(2019, 07, 30, 16, 9, 0) };
            Reply r25_2 = new Reply() { ApplicationUser = a3, Post = p25, Text = "Python is well suited to object orientated programming in that it allows the definition of classes along with composition and inheritance. Python does not have access specifiers (like C++’s public, private).", DateTime = new DateTime(2019, 07, 30, 16, 24, 0) };
            Reply r25_3 = new Reply() { ApplicationUser = a13, Post = p25, Text = "In Python, functions are first-class objects. This means that they can be assigned to variables, returned from other functions and passed into functions. Classes are also first class objects", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p26 = new Post() { ApplicationUser = a3, Title = "Python Type of Language", Text = "What type of language is python? Programming or scripting?", DateTime = new DateTime(2019, 09, 13, 16, 0, 0), Tags = new List<Tag>() { tg7 } };
            Reply r26_1 = new Reply() { ApplicationUser = a1, Post = p26, Text = "Python is capable of scripting, but in general sense, it is considered as a general-purpose programming language", DateTime = new DateTime(2019, 09, 13, 16, 7, 0) };
            Reply r26_2 = new Reply() { ApplicationUser = a4, Post = p26, Text = "General-purpose programming language.", DateTime = new DateTime(2019, 09, 13, 16, 14, 0) };
            Reply r26_3 = new Reply() { ApplicationUser = a5, Post = p26, Text = "Capable of scripting, but in general sense, it is considered as a general-purpose programming language", DateTime = new DateTime(2019, 09, 13, 17, 18, 0) };

            Post p27 = new Post() { ApplicationUser = a3, Title = "Memory managed in Python", Text = "How is memory managed in Python?", DateTime = new DateTime(2019, 07, 10, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r27_1 = new Reply() { ApplicationUser = a1, Post = p27, Text = "Memory management in python is managed by Python private heap space. All Python objects and data structures are located in a private heap. The programmer does not have access to this private heap. The python interpreter takes care of this instead", DateTime = new DateTime(2019, 07, 10, 16, 7, 0) };
            Reply r27_2 = new Reply() { ApplicationUser = a4, Post = p27, Text = "The allocation of heap space for Python objects is done by Python’s memory manager. The core API gives access to some tools for the programmer to code.", DateTime = new DateTime(2019, 07, 10, 16, 14, 0) };
            Reply r27_3 = new Reply() { ApplicationUser = a15, Post = p27, Text = "Python also has an inbuilt garbage collector, which recycles all the unused memory and so that it can be made available to the heap space.", DateTime = new DateTime(2019, 07, 10, 17, 18, 0) };

            Post p28 = new Post() { ApplicationUser = a7, Title = "Python Django", Text = "What is the difference between Django, Pyramid, and Flask?", DateTime = new DateTime(2019, 03, 21, 16, 0, 0), Tags = new List<Tag>() { tg7 } };
            Reply r28_1 = new Reply() { ApplicationUser = a1, Post = p28, Text = "Flask is a microframework primarily build for a small application with simpler requirements. In flask, you don't have to use external libraries. Flask is ready to use.", DateTime = new DateTime(2019, 03, 21, 16, 7, 0) };
            Reply r28_2 = new Reply() { ApplicationUser = a2, Post = p28, Text = "Pyramid are build for larger applications. It provides flexibility and lets the developer use the right tools for their project. The developer can choose the database, URL structure, templating style and more. Pyramid is heavy configurable.", DateTime = new DateTime(2019, 03, 21, 16, 14, 0) };
            Reply r28_3 = new Reply() { ApplicationUser = a6, Post = p28, Text = "Like Pyramid, Django can also used for larger applications. It includes an ORM.", DateTime = new DateTime(2019, 03, 21, 17, 18, 0) };

            Post p29 = new Post() { ApplicationUser = a1, Title = "Java loops", Text = "How do I break out of nested loops in Java?", DateTime = new DateTime(2019, 04, 28, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r29_1 = new Reply() { ApplicationUser = a3, Post = p29, Text = "You can use break with a label for the outer loop.", DateTime = new DateTime(2019, 04, 28, 16, 7, 0) };
            Reply r29_2 = new Reply() { ApplicationUser = a4, Post = p29, Text = "I'd definitely prefer to put the loops in a different method, at which point you can just return to stop iterating completely.", DateTime = new DateTime(2019, 04, 28, 16, 14, 0) };
            Reply r29_3 = new Reply() { ApplicationUser = a15, Post = p29, Text = "Just use the brake", DateTime = new DateTime(2019, 04, 28, 17, 18, 0) };

            Post p30 = new Post() { ApplicationUser = a9, Title = "JDK, JRE, and JVM ", Text = "What is the difference between JDK, JRE, and JVM?", DateTime = new DateTime(2019, 11, 24, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r30_1 = new Reply() { ApplicationUser = a2, Post = p30, Text = "JVM is an acronym for Java Virtual Machine; it is an abstract machine which provides the runtime environment in which Java bytecode can be executed. It is a specification which specifies the working of Java Virtual Machine. Its implementation has been provided by Oracle and other companies. Its implementation is known as JRE.", DateTime = new DateTime(2019, 11, 25, 16, 9, 0) };
            Reply r30_2 = new Reply() { ApplicationUser = a3, Post = p30, Text = "JVMs are available for many hardware and software platforms (so JVM is platform dependent). It is a runtime instance which is created when we run the Java class. There are three notions of the JVM: specification, implementation, and instance.", DateTime = new DateTime(2019, 11, 25, 16, 14, 0) };
            Reply r30_3 = new Reply() { ApplicationUser = a5, Post = p30, Text = "JRE stands for Java Runtime Environment. It is the implementation of JVM. The Java Runtime Environment is a set of software tools which are used for developing Java applications. It is used to provide the runtime environment. It is the implementation of JVM. It physically exists. It contains a set of libraries + other files that JVM uses at runtime.", DateTime = new DateTime(2019, 11, 26, 18, 18, 0) };

            Post p31 = new Post() { ApplicationUser = a10, Title = "JVM Java", Text = "How many types of memory areas are allocated by JVM?", DateTime = new DateTime(2019, 07, 28, 16, 0, 0), Tags = new List<Tag>() { tg1 } };
            Reply r31_1 = new Reply() { ApplicationUser = a1, Post = p31, Text = "Class(Method) Area: Class Area stores per-class structures such as the runtime constant pool, field, method data, and the code for methods.", DateTime = new DateTime(2019, 07, 28, 16, 7, 0) };
            Reply r31_2 = new Reply() { ApplicationUser = a4, Post = p31, Text = "Heap: It is the runtime data area in which the memory is allocated to the objectsStack: Java Stack stores frames.", DateTime = new DateTime(2019, 07, 28, 16, 14, 0) };
            Reply r31_3 = new Reply() { ApplicationUser = a2, Post = p31, Text = "Program Counter Register: PC (program counter) register contains the address of the Java virtual machine instruction currently being executed.Native Method Stack: It contains all the native methods used in the application.", DateTime = new DateTime(2019, 07, 28, 17, 18, 0) };

            Post p32 = new Post() { ApplicationUser = a11, Title = "Differences between the Java platform and other platforms", Text = "What are the main differences between the Java platform and other platforms?", DateTime = new DateTime(2019, 02, 15, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r32_1 = new Reply() { ApplicationUser = a1, Post = p32, Text = "Java is the software-based platform whereas other platforms may be the hardware platforms or software-based platforms.", DateTime = new DateTime(2019, 02, 15, 16, 7, 0) };
            Reply r32_2 = new Reply() { ApplicationUser = a4, Post = p32, Text = "Java is executed on the top of other hardware platforms whereas other platforms can only have the hardware components.", DateTime = new DateTime(2019, 02, 15, 16, 14, 0) };
            Reply r32_3 = new Reply() { ApplicationUser = a3, Post = p32, Text = "Java is executed on the top of other hardware platforms", DateTime = new DateTime(2019, 02, 15, 17, 18, 0) };

            Post p33 = new Post() { ApplicationUser = a11, Title = "Classloader", Text = "What is classloader??", DateTime = new DateTime(2019, 12, 28, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r33_1 = new Reply() { ApplicationUser = a1, Post = p33, Text = "Bootstrap ClassLoader: This is the first classloader which is the superclass of Extension classloader. It loads the rt.jar file which contains all class files of Java Standard Edition like java.lang package classes, java.net package classes, java.util package classes, java.io package classes, java.sql package classes, etc.", DateTime = new DateTime(2019, 12, 18, 17, 7, 0) };
            Reply r33_2 = new Reply() { ApplicationUser = a4, Post = p33, Text = "Extension ClassLoader: This is the child classloader of Bootstrap and parent classloader of System classloader. It loads the jar files located inside $JAVA_HOME/jre/lib/ext directory.", DateTime = new DateTime(2019, 12, 28, 18, 14, 0) };
            Reply r33_3 = new Reply() { ApplicationUser = a2, Post = p33, Text = "System/Application ClassLoader: This is the child classloader of Extension classloader. It loads the class files from the classpath. By default, the classpath is set to the current directory. You can change the classpath using classpath switch. It is also known as Application classloader.", DateTime = new DateTime(2019, 12, 28, 20, 14, 0) };

            Post p34 = new Post() { ApplicationUser = a12, Title = "OOP Paradigm", Text = "What is object-oriented paradigm??", DateTime = new DateTime(2019, 05, 29, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r34_1 = new Reply() { ApplicationUser = a1, Post = p34, Text = "It is a programming paradigm based on objects having data and methods defined in the class to which it belongs.", DateTime = new DateTime(2019, 05, 29, 16, 23, 0) };
            Reply r34_2 = new Reply() { ApplicationUser = a2, Post = p34, Text = "Object-oriented paradigm aims to incorporate the advantages of modularity and reusability. Objects are the instances of classes which interacts with one another to design applications and programs.", DateTime = new DateTime(2019, 05, 29, 18, 14, 0) };
            Reply r34_3 = new Reply() { ApplicationUser = a3, Post = p34, Text = "Includes the concept like Encapsulation and abstraction which hides the complexities from the user and show only functionality.", DateTime = new DateTime(2019, 06, 30, 17, 18, 0) };

            Post p35 = new Post() { ApplicationUser = a13, Title = "object-oriented programming language and object-based programming language ", Text = " What is the difference between an object-oriented programming language and object-based programming language?", DateTime = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r35_1 = new Reply() { ApplicationUser = a4, Post = p35, Text = "Object - oriented languages follow all the concepts of OOPs whereas,the object - based language doesn't follow all the concepts of OOPs like inheritance and polymorphism..", DateTime = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r35_2 = new Reply() { ApplicationUser = a5, Post = p35, Text = "Object-oriented languages do not have the inbuilt objects whereas Object-based languages have the inbuilt objects, for example, JavaScript has window object", DateTime = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r35_3 = new Reply() { ApplicationUser = a1, Post = p35, Text = "Examples of object-oriented programming are Java, C#, Smalltalk, etc. whereas the examples of object-based languages are JavaScript, VBScript, etc.", DateTime = new DateTime(2019, 12, 30, 17, 18, 0) };

            Post p36 = new Post() { ApplicationUser = a1, Title = "Static methods at Abstract class", Text = " Hello Everyone!Can I declare the static variables and methods in an abstract class?", DateTime = new DateTime(2019, 04, 28, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r36_1 = new Reply() { ApplicationUser = a3, Post = p36, Text = "Yes Of Course!", DateTime = new DateTime(2019, 04, 28, 16, 7, 0) };
            Reply r36_2 = new Reply() { ApplicationUser = a4, Post = p36, Text = "Yes, we can declare static variables and methods in an abstract method. ", DateTime = new DateTime(2019, 04, 28, 16, 14, 0) };
            Reply r36_3 = new Reply() { ApplicationUser = a15, Post = p36, Text = "As we know that there is no requirement to make the object to access the static context, therefore, we can access the static context declared inside the abstract class by using the name of the abstract class.", DateTime = new DateTime(2019, 04, 28, 17, 18, 0) };

            Post p37 = new Post() { ApplicationUser = a9, Title = "This keyword in java", Text = "What is this keyword in java?", DateTime = new DateTime(2019, 11, 24, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r37_1 = new Reply() { ApplicationUser = a2, Post = p37, Text = "The this keyword is a reference variable that refers to the current object.", DateTime = new DateTime(2019, 11, 25, 16, 9, 0) };
            Reply r37_2 = new Reply() { ApplicationUser = a3, Post = p37, Text = "There are the various uses of this keyword in Java. It can be used to refer to current class properties such as instance methods, variable, constructors, etc.", DateTime = new DateTime(2019, 11, 25, 16, 14, 0) };
            Reply r37_3 = new Reply() { ApplicationUser = a5, Post = p37, Text = "It can also be passed as an argument into the methods or constructors. It can also be returned from the method as the current class instance.", DateTime = new DateTime(2019, 11, 26, 18, 18, 0) };

            Post p38 = new Post() { ApplicationUser = a10, Title = "This keyword uses in java", Text = "What are the main uses of this keyword?", DateTime = new DateTime(2019, 07, 28, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r38_1 = new Reply() { ApplicationUser = a1, Post = p38, Text = "This can be used to refer to the current class instance variable", DateTime = new DateTime(2019, 07, 28, 16, 7, 0) };
            Reply r38_2 = new Reply() { ApplicationUser = a4, Post = p38, Text = "This can be used to invoke current class method (implicitly)", DateTime = new DateTime(2019, 07, 28, 16, 14, 0) };
            Reply r38_3 = new Reply() { ApplicationUser = a2, Post = p38, Text = "This() can be used to invoke the current class constructor.", DateTime = new DateTime(2019, 07, 28, 17, 18, 0) };

            Post p39 = new Post() { ApplicationUser = a11, Title = "Passing this into a Method-Java", Text = "What are the advantages of passing this into a method instead of the current class object itself?", DateTime = new DateTime(2019, 02, 15, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r39_1 = new Reply() { ApplicationUser = a1, Post = p39, Text = "As we know, that this refers to the current class object, therefore, it must be similar to the current class object.", DateTime = new DateTime(2019, 02, 15, 16, 7, 0) };
            Reply r39_2 = new Reply() { ApplicationUser = a4, Post = p39, Text = "this is a final variable. Therefore, this cannot be assigned to any new value whereas the current class object might not be final and can be changed.", DateTime = new DateTime(2019, 02, 15, 16, 14, 0) };
            Reply r39_3 = new Reply() { ApplicationUser = a3, Post = p39, Text = " this can be used in the synchronized block.", DateTime = new DateTime(2019, 02, 15, 17, 18, 0) };

            Post p40 = new Post() { ApplicationUser = a11, Title = "Inheritance Java", Text = "What is the Inheritance??", DateTime = new DateTime(2019, 12, 28, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r40_1 = new Reply() { ApplicationUser = a1, Post = p40, Text = "Inheritance is a mechanism by which one object acquires all the properties and behavior of another object of another class. It is used for Code Reusability and Method Overriding. The idea behind inheritance in Java is that you can create new classes that are built upon existing classes.", DateTime = new DateTime(2019, 12, 18, 17, 7, 0) };
            Reply r40_2 = new Reply() { ApplicationUser = a4, Post = p40, Text = "When you inherit from an existing class, you can reuse methods and fields of the parent class. ", DateTime = new DateTime(2019, 12, 28, 18, 14, 0) };
            Reply r40_3 = new Reply() { ApplicationUser = a2, Post = p40, Text = "Moreover, you can add new methods and fields in your current class also. Inheritance represents the IS-A relationship which is also known as a parent-child relationship..", DateTime = new DateTime(2019, 12, 28, 20, 14, 0) };

            Post p41 = new Post() { ApplicationUser = a12, Title = "Why is Inheritance used in Java?", Text = "Why is Inheritance used in Java and how usefull could be for a new Developer?", DateTime = new DateTime(2019, 05, 29, 16, 0, 0), Tags = new List<Tag>() { tg8 } };
            Reply r41_1 = new Reply() { ApplicationUser = a1, Post = p41, Text = "Inheritance provides code reusability. The derived class does not need to redefine the method of base class unless it needs to provide the specific implementation of the method.", DateTime = new DateTime(2019, 05, 29, 16, 23, 0) };
            Reply r41_2 = new Reply() { ApplicationUser = a2, Post = p41, Text = "Runtime polymorphism cannot be achieved without using inheritance.", DateTime = new DateTime(2019, 05, 29, 18, 14, 0) };
            Reply r41_3 = new Reply() { ApplicationUser = a3, Post = p41, Text = "Method overriding cannot be achieved without inheritance. By method overriding, we can give a specific implementation of some basic method contained by the base class.", DateTime = new DateTime(2019, 06, 30, 17, 18, 0) };

            Post p42 = new Post() { ApplicationUser = a13, Title = "Doubly fed induction generator (DFIG) ", Text = "How is the neutral point of the stator of a doubly fed induction generator (DFIG) connected??", DateTime = new DateTime(2019, 08, 12, 16, 0, 0), Tags = new List<Tag>() { tg3 } };
            Reply r42_1 = new Reply() { ApplicationUser = a4, Post = p42, Text = "If there is a difference between the three voltages, the best way for modelling is to make the transformation to Valfa, Vbeta and Vo. In this case Vo will be taken in consideration if the neutral is connected, other was it will be a floating voltage.", DateTime = new DateTime(2019, 08, 12, 16, 7, 0) };
            Reply r42_2 = new Reply() { ApplicationUser = a5, Post = p42, Text = "There is a difference between an autonomus induction generator and that connected to a grid. In this case the grid will impose the 3 voltages va, vb and vc..", DateTime = new DateTime(2019, 08, 12, 16, 14, 0) };
            Reply r42_3 = new Reply() { ApplicationUser = a1, Post = p42, Text = "There is a difference between an autonomus induction generator and that connected to a grid.", DateTime = new DateTime(2019, 08, 30, 17, 18, 0) };

            Post p43 = new Post() { ApplicationUser = a20, Title = "macro in Visual Basic .NET ", Text = "How to write a macro in Visual Basic .NET or in Visual Basic 2017 that automatically creates combobox a number of times??", DateTime = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg3 } };
            Reply r43_1 = new Reply() { ApplicationUser = a4, Post = p43, Text = "For i As Integer = 1 To Integer.Parse(TextBox1.Text)Dim tb As TextBoxtb = New TextBox()tb.Location = New Point(0, i * 30)tb.Text = i.ToString()Panel1.Controls.Add(tb).", DateTime = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r43_2 = new Reply() { ApplicationUser = a5, Post = p43, Text = "With TextBox1 as txtbox where the number of items is written and preferrably a button to handle the event and Panel1 as the target element.", DateTime = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r43_3 = new Reply() { ApplicationUser = a1, Post = p43, Text = "Remember to take into account that no event handlers have been defined for the added element yet.", DateTime = new DateTime(2019, 12, 30, 17, 18, 0) };

            Post p44 = new Post() { ApplicationUser = a7, Title = "Early Binding vs Late Binding", Text = "Early Binding vs Late Binding Whats the differences?", DateTime = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg3 } };
            Reply r44_1 = new Reply() { ApplicationUser = a4, Post = p44, Text ="Early binding allows developers to interact with the object’s properties and methods during coding permits the compiler to check your code.Errors are caught at compile time.Early binding also results in faster codeEg : Dim ex as new Excel.Application", DateTime = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r44_2 = new Reply() { ApplicationUser = a5, Post = p44, Text = "Late binding on the other hand permits defining generic objects which may be bound to different objectsyou could declare myControl as Control without knowing which control you will encounter.", DateTime = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r44_3 = new Reply() { ApplicationUser = a1, Post = p44, Text = "You could query the Controls collection and determine which control you are working on using the TypeOf method and branch to the section of your code that provides for that type", DateTime = new DateTime(2019, 12, 30, 17, 18, 0) };

            Post p45 = new Post() { ApplicationUser = a8, Title = "Flexgrid and dbgrid control- Basic", Text = "What is the differences between flexgrid and dbgrid control?", DateTime = new DateTime(2019, 07, 12, 16, 0, 0), Tags = new List<Tag>() { tg3 } };
            Reply r45_1 = new Reply() { ApplicationUser = a4, Post = p45, Text = "Microsoft FlexGrid (MSFlexGrid) control displays and operates on tabular data", DateTime = new DateTime(2019, 07, 12, 16, 7, 0) };
            Reply r45_2 = new Reply() { ApplicationUser = a5, Post = p45, Text = "Microsoft FlexGrid (MSFlexGrid) control displays and operates on tabular data. It allows programmatically sort, merge, and format tables containing strings and pictures.", DateTime = new DateTime(2019, 12, 30, 16, 14, 0) };
            Reply r45_3 = new Reply() { ApplicationUser = a1, Post = p45, Text = "DBgrid is A spreadsheet-like bound control that displays a series of rows and columns representing records and fields from a ADO Recordset object.", DateTime = new DateTime(2019, 12, 30, 17, 18, 0) };

<<<<<<< HEAD
            // CREATING BOOKS
>>>>>>> Seeding Users-Posts-Replies-Books with real Info
=======
            // *** ~~~ ~~~ ~~~ *** Books *** ~~~ ~~~ ~~~ ***

>>>>>>> Rebase Conflicts Try
            Book b1 = new Book() { BookAuthor = "Peter Rich", Title = "Programming with C", Description = "An whole new approach to the C programming", Publisher = "Random Books", Pages = 133, DateTime = new DateTime(2001, 04, 09) };
            Book b2 = new Book() { BookAuthor = "Olga Moskovskaya", Title = "The windows GUI", Description = "This is an introduction of the windows OS GUI", Publisher = "Little House", Pages = 300, DateTime = new DateTime(2008, 07, 25) };
            Book b3 = new Book() { BookAuthor = "Anna Petersson", Title = "History of Computing", Description = "The events that marked the rise of computing era", Publisher = "Random Books", Pages = 500, DateTime = new DateTime(2017, 04, 18) };
            Book b4 = new Book() { BookAuthor = "John Stone", Title = "The Linux OS", Description = "A deep understanding of a popular OS", Publisher = "Bird House", Pages = 100, DateTime = new DateTime(2016, 01, 31) };
            Book b5 = new Book() { BookAuthor = "Alice Booker", Title = "Basic Cryptography", Description = "An introduction to basic principles of cryptography", Publisher = "Hidden Books", Pages = 150, DateTime = new DateTime(2012, 02, 29) };
            Book b6 = new Book() { BookAuthor = "David Thomas", Title = "The Pragmatic Programmer", Description = "Whether you’re new to the field or an experienced practitioner, you’ll come away with fresh insights each and every time. ", Publisher = "David Thomas", Pages = 352, DateTime = new DateTime(2019, 07, 30) };
            Book b7 = new Book() { BookAuthor = "Robert C.Uncle Bob Martin", Title = "Clean Code", Description = "Even bad code can function. But if code isn’t clean, it can bring a development organization to its knees.", Publisher = "Prentice Hall", Pages = 464, DateTime = new DateTime(2008, 08, 01) };
            Book b8 = new Book() { BookAuthor = "Dr.Erich Gamma", Title = "Design Patterns", Description = "Capturing a wealth of experience about the design of object-oriented software, four top-notch designers present a catalog of simple and succinct solutions to commonly occurring design problems.", Publisher = "Addison-Wesley ", Pages = 416, DateTime = new DateTime(1994, 10, 30) };
            Book b9 = new Book() { BookAuthor = "Eric Freeman", Title = "Head First Design Patterns", Description = "Design Patterns", Publisher = " O'Reilly Media", Pages = 694, DateTime = new DateTime(2004, 10, 01) };
            Book b10 = new Book() { BookAuthor = "Jon Bentley", Title = "Programming Pearls", Description = "An introduction to basic principles of cryptography", Publisher = "Addison-Wesley", Pages = 258, DateTime = new DateTime(2016, 04, 21) };

<<<<<<< HEAD
<<<<<<< HEAD
            // *** ~~~ ~~~ ~~~ *** Tutorials *** ~~~ ~~~ ~~~ ***
=======
            // CREATING TUTORIALS
>>>>>>> Seeding Users-Posts-Replies-Books with real Info
=======
            // *** ~~~ ~~~ ~~~ *** Tutorials *** ~~~ ~~~ ~~~ ***

>>>>>>> Rebase Conflicts Try
            Tutorial tu1 = new Tutorial() { TutorialAuthor = "Dr. Hans Stroke", Title = "Learn C++", Description = "An all around approach to the C++ programming language.", Duration = TimeSpan.FromMinutes(120), DateTime = new DateTime(2004, 06, 02) };
            Tutorial tu2 = new Tutorial() { TutorialAuthor = "John Fields", Title = "Advanced C#", Description = "Advanced topics of the C# programming, like delegates, generics and pointer handling.", Duration = TimeSpan.FromMinutes(140), DateTime = new DateTime(2017, 01, 23) };
            Tutorial tu3 = new Tutorial() { TutorialAuthor = "Mary Green", Title = "Beginner\'s C#", Description = "An introduction to the C#, including variables, classes and methods.", Duration = TimeSpan.FromMinutes(110), DateTime = new DateTime(2013, 01, 12) };
            Tutorial tu4 = new Tutorial() { TutorialAuthor = "Steven Orange", Title = "Absolute C Tutorial", Description = "This is a tutorial of C programming, with emphasis on low level techniques.", Duration = TimeSpan.FromMinutes(90), DateTime = new DateTime(2009, 07, 17) };
            Tutorial tu5 = new Tutorial() { TutorialAuthor = "Bill Windows", Title = "Python for Beginners", Description = "Learn Python, an exceptional choice for introduction to programming.", Duration = TimeSpan.FromMinutes(60), DateTime = new DateTime(2015, 03, 01) };

<<<<<<< HEAD
<<<<<<< HEAD
            // *** ~~~ ~~~ ~~~ *** UserProducts (Per UserID) *** ~~~ ~~~ ~~~ ***
=======
            // *** ~~~ ~~~ ~~~ *** UserProducts (Per UserID) *** ~~~ ~~~ ~~~ ***

>>>>>>> Rebase Conflicts Try
            UserProduct up1 = new UserProduct() { ApplicationUser_Id = a1.Id, TransactionTime = new DateTime(2020, 1, 1), Price = 10m };
            UserProduct up2 = new UserProduct() { ApplicationUser_Id = a2.Id, TransactionTime = new DateTime(2019, 11, 14), Price = 9.95m };
            UserProduct up3 = new UserProduct() { ApplicationUser_Id = a2.Id, TransactionTime = new DateTime(2019, 12, 3), Price = 14.95m };
            UserProduct up4 = new UserProduct() { ApplicationUser_Id = a3.Id, TransactionTime = new DateTime(2019, 12, 5), Price = 14.45m };
            UserProduct up5 = new UserProduct() { ApplicationUser_Id = a4.Id, TransactionTime = new DateTime(2019, 12, 9), Price = 14.95m };
            UserProduct up6 = new UserProduct() { ApplicationUser_Id = a4.Id, TransactionTime = new DateTime(2019, 12, 10), Price = 19.9m };
            UserProduct up7 = new UserProduct() { ApplicationUser_Id = a4.Id, TransactionTime = new DateTime(2019, 12, 11), Price = 5.95m };

<<<<<<< HEAD
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
<<<<<<< HEAD
=======
            context.Replies.AddOrUpdate(x => x.Text, r1_1, r1_2,
                r2_1, r2_2, r2_3,
                r3_1, r3_2, r3_3,
                r4_1, r4_2, r4_3,
                r5_1, r5_2, r5_3,
                r6_1, r6_2, r6_3,
                r7_1, r7_2, r7_3,
                r8_1, r8_2, r8_3,
                r9_1, r9_2, r9_3,
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
                r28_1, r28_2, r28_3
                );
            context.Posts.AddOrUpdate(x => x.Text, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28);
>>>>>>> Seeding Updated,Post Controller Updated
            context.Products.AddOrUpdate(x => x.Title, tu1, tu2, tu3, tu4, tu5, b1, b2, b3, b4, b5);
=======
            // CREATING USER PER PRODUCT
            UserProduct up1 = new UserProduct() { ApplicationUser = a1, Product = b1, TransactionTime = new DateTime(2020, 1, 1), Price = 100m };
            UserProduct up2 = new UserProduct() { ApplicationUser = a2, Product = tu1, TransactionTime = new DateTime(2019, 11, 14), Price = 9.95m };
=======
            // *** ~~~ ~~~ ~~~ *** Video Files *** ~~~ ~~~ ~~~ ***
>>>>>>> Rebase Conflicts Try

            VideoFile v1 = new VideoFile() { Vname = "NightStalker", Vpath = "~/VideoFiles/NIGHTSTALKER - Sweet Knife (HD Official Music Video).mp4" };

            // *** ~~~ ~~~ ~~~ *** Image Files *** ~~~ ~~~ ~~~ ***

            ImageFile img1 = new ImageFile() { ImgName = "Schema", ImgPath = "~/ImageFiles/σχημα.PNG" };



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




            context.Users.AddOrUpdate(x => x.UserName, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20);
            context.Tags.AddOrUpdate(x => x.Title, tg1, tg2, tg3, tg4, tg5, tg6, tg7, tg8);
            context.Posts.AddOrUpdate(x => x.Text, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28,p29,p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40,p41,p42,p43,p44,p45);
            context.Replies.AddOrUpdate(x => x.Text, r1_1, r1_2,
            r2_1, r2_2, r2_3,
            r3_1, r3_2, r3_3,
            r4_1, r4_2, r4_3,
            r5_1, r5_2, r5_3,
            r6_1, r6_2, r6_3,
            r7_1, r7_2, r7_3,
            r8_1, r8_2, r8_3,
            r9_1, r9_2, r9_3,
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
            r45_1, r45_2, r45_3
            );
            context.Products.AddOrUpdate(x => x.Title, tu1, tu2, tu3, tu4, tu5, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10);
            context.UserProducts.AddOrUpdate(x => x.TransactionTime, up1, up2);
>>>>>>> Seeding Users-Posts-Replies-Books with real Info
            context.VideoFiles.AddOrUpdate(x => x.Vname, v1);
            context.ImageFiles.AddOrUpdate(x => x.ImgName, img1);
            context.SaveChanges();

            #endregion
        }
    }
}
