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
            ApplicationUser a1 = new ApplicationUser() { FirstName = "Maria", LastName = "Kalimeri", DateOfBirth = new DateTime(1993, 05, 27), UserName = "mkalimeri93" };
            ApplicationUser a2 = new ApplicationUser() { FirstName = "Nikolaos", LastName = "Koromilakis", DateOfBirth = new DateTime(1980, 09, 18), UserName = "nkoromilakis80" };
            ApplicationUser a3 = new ApplicationUser() { FirstName = "Konstantinos", LastName = "Peponakis", DateOfBirth = new DateTime(2001, 07, 23), UserName = "kpeponakis01" };
            ApplicationUser a4 = new ApplicationUser() { FirstName = "Anna", LastName = "Karpouzaki", DateOfBirth = new DateTime(1996, 01, 31), UserName = "akarpouzaki96" };
            ApplicationUser a5 = new ApplicationUser() { FirstName = "Pinelopi", LastName = "Portokalaki", DateOfBirth = new DateTime(1998, 05, 16), UserName = "pportokalaki98" };
            ApplicationUser a6 = new ApplicationUser() { FirstName = "John", LastName = "Papadopoulos", DateOfBirth = new DateTime(1997, 04, 16), UserName = "pap19" };
            ApplicationUser a7 = new ApplicationUser() { FirstName = "Costas", LastName = "Ioannou", DateOfBirth = new DateTime(1993, 03, 16), UserName = "Ioannou93" };
            ApplicationUser a8 = new ApplicationUser() { FirstName = "Karol", LastName = "Koniewic", DateOfBirth = new DateTime(1994, 02, 16), UserName = "Kokarol94" };


>>>>>>> Seeding updated
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

<<<<<<< HEAD
            // *** ~~~ ~~~ ~~~ *** Replies Per User *** ~~~ ~~~ ~~~ ***
            a1.Replies = new List<Reply>() { r3 };
            a2.Replies = new List<Reply>() { r1 };
            a4.Replies = new List<Reply>() { r4 };
            a5.Replies = new List<Reply>() { r2, r5 };
=======
            Post p3 = new Post() { ApplicationUser = a3, Title = "How to create a new context per every async", Text = "And actually this test is green", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };

            Reply r3_1 = new Reply() { ApplicationUser = a1, Post = p3, Text = "What do you mean by create a stack of scopes per every new async operation? If you have methodA calls methodB, and both are async methods, do you mean you want to create two scopes one for each?", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r3_2 = new Reply() { ApplicationUser = a2, Post = p3, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r3_3 = new Reply() { ApplicationUser = a5, Post = p3, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p4 = new Post() { ApplicationUser = a4, Title = "Top 52 C# Interview Questions & Answers", Text = "1. What is C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r4_1 = new Reply() { ApplicationUser = a2, Post = p4, Text = "C# is an object-oriented, type-safe, and managed language that is compiled by .Net framework to generate Microsoft Intermediate Language.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r4_2 = new Reply() { ApplicationUser = a3, Post = p4, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r4_3 = new Reply() { ApplicationUser = a4, Post = p4, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p5 = new Post() { ApplicationUser = a5, Title = "Boxing and Unboxing", Text = "What is Boxing and Unboxing in C", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r5_1 = new Reply() { ApplicationUser = a1, Post = p5, Text = "Boxing and Unboxing both are used for type conversions.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r5_2 = new Reply() { ApplicationUser = a2, Post = p5, Text = "The process of converting from a value type to a reference type is called boxing.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r5_3 = new Reply() { ApplicationUser = a3, Post = p5, Text = "The process of converting from a reference type to a value type is called unboxing. Here is an example of unboxing in C#.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p6 = new Post() { ApplicationUser = a5, Title = "struct and class in C#", Text = "What is the difference between a struct and a class in C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r6_1 = new Reply() { ApplicationUser = a3, Post = p6, Text = "The struct is a value type in C# and it inherits from System.Value Type.Struct is usually used for smaller amounts of data.The class is a reference type in C# and it inherits from the System.Object Type", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r6_2 = new Reply() { ApplicationUser = a1, Post = p6, Text = "Struct can’t be inherited from other types.A structure can't be abstract", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r6_3 = new Reply() { ApplicationUser = a5, Post = p6, Text = "A class can be an abstract type.Classes can be inherited from other classes", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p7 = new Post() { ApplicationUser = a3, Title = "Interface and Abstract Class in C#", Text = "What is the difference between Interface and Abstract Class in C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r7_1 = new Reply() { ApplicationUser = a2, Post = p7, Text = "A class can implement any number of interfaces but a subclass can at most use only one abstract class.An abstract class can have non-abstract methods(concrete methods) while in case of interface, all the methods have to be abstract.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r7_2 = new Reply() { ApplicationUser = a3, Post = p7, Text = "An abstract class can declare or use any variables while an interface is not allowed to do so.In an abstract class, all data members or functions are private by default while in an interface all are public, we can’t change them manually.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r7_3 = new Reply() { ApplicationUser = a5, Post = p7, Text = "In an abstract class, we need to use abstract keywords to declare abstract methods, while in an interface we don’t need to use that.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p8 = new Post() { ApplicationUser = a2, Title = "Enum in C#", Text = "What is enum in C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r8_1 = new Reply() { ApplicationUser = a1, Post = p8, Text = "An enum is a value type with a set of related named constants often referred to as an enumerator list. The enum keyword is used to declare an enumeration. It is a primitive data type that is user-defined.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r8_2 = new Reply() { ApplicationUser = a4, Post = p8, Text = "An enum type can be an integer (float, int, byte, double, etc.). But if you use it beside int it has to be cast.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r8_3 = new Reply() { ApplicationUser = a2, Post = p8, Text = "An enum is used to create numeric constants in the .NET framework. All the members of enum are enum type. There must be a numeric value for each enum type.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p9 = new Post() { ApplicationUser = a2, Title = "Continue and Break statements", Text = "Whats the diffence of Continue and Break statements", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r9_1 = new Reply() { ApplicationUser = a1, Post = p9, Text = "Using break statement, you can 'jump out of a loop' whereas by using a continue statement, you can 'jump over one iteration' and then resume your loop execution", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r9_2 = new Reply() { ApplicationUser = a4, Post = p9, Text = "The continue statement passes control to the next iteration", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r9_3 = new Reply() { ApplicationUser = a3, Post = p9, Text = " you can 'jump over one iteration' and then resume your loop execution", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p10 = new Post() { ApplicationUser = a3, Title = "Constant and readonly in C#", Text = "What is the difference between constant and readonly in C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r10_1 = new Reply() { ApplicationUser = a1, Post = p10, Text = "Const is nothing but constant, a variable of which the value is constant but at compile time.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r10_2 = new Reply() { ApplicationUser = a4, Post = p10, Text = "By default, a const is static and we cannot change the value of a const variable throughout the entire program.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r10_3 = new Reply() { ApplicationUser = a2, Post = p10, Text = "Readonly is the keyword whose value we can change during runtime or we can assign it at run time but only through the non-static constructor.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p11 = new Post() { ApplicationUser = a5, Title = "Ref and out keywords", Text = "What is the difference between ref and out keywords?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r11_1 = new Reply() { ApplicationUser = a1, Post = p11, Text = "The ref keyword passes arguments by reference. It means any changes made to this argument in the method will be reflected in that variable when control returns to the calling method.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r11_2 = new Reply() { ApplicationUser = a2, Post = p11, Text = "The out keyword passes arguments by reference. This is very similar to the ref keyword.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r11_3 = new Reply() { ApplicationUser = a3, Post = p11, Text = "Both ref and out are treated differently at run time and they are treated the same at compile time, so methods cannot be overloaded if one method takes an argument as ref and the other takes an argument as an out.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p12 = new Post() { ApplicationUser = a3, Title = "'This' keyword with static Methods ", Text = "Can 'this' be used within a static method?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r12_1 = new Reply() { ApplicationUser = a4, Post = p12, Text = "We can't use 'this' in a static method because the keyword 'this' returns a reference to the current instance of the class containing it.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r12_2 = new Reply() { ApplicationUser = a5, Post = p12, Text = "Static methods (or any static member) do not belong to a particular instance. They exist without creating an instance of the class and are called with the name of a class, not by instance, so we can’t use this keyword in the body of static Methods.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r12_3 = new Reply() { ApplicationUser = a1, Post = p12, Text = "The 'this' keyword in C# is a special type of reference variable that is implicitly defined within each constructor and non-static method as a first parameter of the type class in which it is defined.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p13 = new Post() { ApplicationUser = a3, Title = "Comments in HTML", Text = "How can I insert a comment in HTML?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r13_1 = new Reply() { ApplicationUser = a1, Post = p13, Text = "Comments in HTML begins with <!–  ends with –>.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r13_2 = new Reply() { ApplicationUser = a8, Post = p13, Text = "<!--    -->", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r13_3 = new Reply() { ApplicationUser = a5, Post = p13, Text = "<!-- A SAMPLE COMMENT -->", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p14 = new Post() { ApplicationUser = a3, Title = "Image map", Text = "What is an image map?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r14_1 = new Reply() { ApplicationUser = a1, Post = p14, Text = "Image map lets you link to many different web pages using a single image.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r14_2 = new Reply() { ApplicationUser = a4, Post = p14, Text = "You can define shapes in images that you want to make part of an image mapping.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r14_3 = new Reply() { ApplicationUser = a5, Post = p14, Text = "You can define shapes in images ", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p15 = new Post() { ApplicationUser = a3, Title = "Collapsing white space", Text = "What is the advantage of collapsing white space?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r15_1 = new Reply() { ApplicationUser = a1, Post = p15, Text = "White spaces are a blank sequence of space characters, which is treated as a single space character in HTML.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r15_2 = new Reply() { ApplicationUser = a4, Post = p15, Text = "Because the browser collapses multiple spaces into a single space, you can indent lines of text without worrying about multiple spaces.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r15_3 = new Reply() { ApplicationUser = a8, Post = p15, Text = "This enables you to organize the HTML code into a much more readable format.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p16 = new Post() { ApplicationUser = a3, Title = "Properties in C#", Text = "What are Properties in C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r16_1 = new Reply() { ApplicationUser = a1, Post = p16, Text = "C# properties are members of a C# class that provide a flexible mechanism to read", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r16_2 = new Reply() { ApplicationUser = a6, Post = p16, Text = "C# properties use get and set methods, also known as accessors, to access and assign values to private fields.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r16_3 = new Reply() { ApplicationUser = a5, Post = p16, Text = "Properties in C# are always public data members.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p17 = new Post() { ApplicationUser = a3, Title = "Extensions Methods", Text = "What are extension methods in C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r17_1 = new Reply() { ApplicationUser = a1, Post = p17, Text = "Extension methods enable you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. ", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r17_2 = new Reply() { ApplicationUser = a4, Post = p17, Text = "An extension method is a special kind of static method, but they are called as if they were instance methods on the extended type.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r17_3 = new Reply() { ApplicationUser = a5, Post = p17, Text = "An extension method is a static method of a static class, where the 'this' modifier is applied to the first parameter. The type of the first parameter will be the type that is extended.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p18 = new Post() { ApplicationUser = a3, Title = "Dispose and finalize methods in C#?", Text = "What is the difference between the dispose and finalize methods in C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r18_1 = new Reply() { ApplicationUser = a7, Post = p18, Text = "In finalize and dispose, both methods are used to free unmanaged resources.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r18_2 = new Reply() { ApplicationUser = a4, Post = p18, Text = "Finalize is used to free unmanaged resources that are not in use, like files, database connections in the application domain and more. These are resources held by an object before that object is destroyed.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r18_3 = new Reply() { ApplicationUser = a8, Post = p18, Text = "In the Internal process, it is called by Garbage Collector and can’t be called manual by user code or any service.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p19 = new Post() { ApplicationUser = a3, Title = "String and StringBuilder in C#", Text = "What is the difference between String and StringBuilder in C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r19_1 = new Reply() { ApplicationUser = a1, Post = p19, Text = "StringBuilder and string are both used to string values, but both have many differences on the bases of instance creation and also in performance.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r19_2 = new Reply() { ApplicationUser = a6, Post = p19, Text = "A string is an immutable object. Immutable is when we create string objects in code so we cannot modify or change that object in any operations like insert new value, replace or append any value with the existing value in a string object.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r19_3 = new Reply() { ApplicationUser = a5, Post = p19, Text = "System.Text.Stringbuilder is a mutable object which also holds the string value, mutable means once we create a System.Text.Stringbuilder object. ", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p20 = new Post() { ApplicationUser = a3, Title = "Delegates in C# and the uses of delegates", Text = "What are delegates?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r20_1 = new Reply() { ApplicationUser = a6, Post = p20, Text = "A Delegate is an abstraction of one or more function pointers", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r20_2 = new Reply() { ApplicationUser = a7, Post = p20, Text = "Delegates are derived from the System.MulticastDelegate class.They have a signature and a return type.A function that is added to delegates must be compatible with this signature.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r20_3 = new Reply() { ApplicationUser = a5, Post = p20, Text = "Delegates can point to either static or instance methods", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p21 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r21_1 = new Reply() { ApplicationUser = a1, Post = p21, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r21_2 = new Reply() { ApplicationUser = a4, Post = p21, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r21_3 = new Reply() { ApplicationUser = a5, Post = p21, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p22 = new Post() { ApplicationUser = a3, Title = "Delegates C#", Text = "Why Do We Need Delegates?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r22_1 = new Reply() { ApplicationUser = a1, Post = p22, Text = "A delegate is a solution for situations in which you want to pass methods around to other methods.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r22_2 = new Reply() { ApplicationUser = a8, Post = p22, Text = "You are so accustomed to passing data to methods as parameters that the idea of passing methods as an argument instead of data might sound a little strange.", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r22_3 = new Reply() { ApplicationUser = a7, Post = p22, Text = "The parameters of the method.The address of the method it calls.The return type of the method.", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p23 = new Post() { ApplicationUser = a3, Title = "Sealed classes C#", Text = "What are sealed classes in C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r23_1 = new Reply() { ApplicationUser = a1, Post = p23, Text = "Sealed classes are used to restrict the inheritance feature of object-oriented programming.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
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
            context.VideoFiles.AddOrUpdate(x => x.Vname, v1);
            context.ImageFiles.AddOrUpdate(x => x.ImgName, img1);
            context.SaveChanges();
            #endregion
        }
    }
}
