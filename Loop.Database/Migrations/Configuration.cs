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

<<<<<<< HEAD
            // *** ~~~ ~~~ ~~~ *** Replies Per User *** ~~~ ~~~ ~~~ ***
            a1.Replies = new List<Reply>() { r3 };
            a2.Replies = new List<Reply>() { r1 };
            a4.Replies = new List<Reply>() { r4 };
            a5.Replies = new List<Reply>() { r2, r5 };
=======
            Post p3 = new Post() { ApplicationUser = a3, Title = "How to create a new context per every async", Text = "And actually this test is green", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };

            Reply r3_1 = new Reply() { ApplicationUser = a1, Post = p3, Text = "What do you mean by create a stack of scopes per every new async operation? If you have methodA calls methodB, and both are async methods, do you mean you want to create two scopes one for each?", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r3_2 = new Reply() { ApplicationUser = a4, Post = p3, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r3_3 = new Reply() { ApplicationUser = a5, Post = p3, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p4 = new Post() { ApplicationUser = a3, Title = "Top 52 C# Interview Questions & Answers", Text = "1. What is C#?", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r4_1 = new Reply() { ApplicationUser = a1, Post = p4, Text = "C# is an object-oriented, type-safe, and managed language that is compiled by .Net framework to generate Microsoft Intermediate Language.", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r4_2 = new Reply() { ApplicationUser = a4, Post = p4, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r4_3 = new Reply() { ApplicationUser = a5, Post = p4, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p5 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r5_1 = new Reply() { ApplicationUser = a1, Post = p5, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r5_2 = new Reply() { ApplicationUser = a4, Post = p5, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r5_3 = new Reply() { ApplicationUser = a5, Post = p5, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p6 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r6_1 = new Reply() { ApplicationUser = a1, Post = p6, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r6_2 = new Reply() { ApplicationUser = a4, Post = p6, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r6_3 = new Reply() { ApplicationUser = a5, Post = p6, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p7 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r7_1 = new Reply() { ApplicationUser = a1, Post = p7, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r7_2 = new Reply() { ApplicationUser = a4, Post = p7, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r7_3 = new Reply() { ApplicationUser = a5, Post = p7, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p8 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r8_1 = new Reply() { ApplicationUser = a1, Post = p8, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r8_2 = new Reply() { ApplicationUser = a4, Post = p8, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r8_3 = new Reply() { ApplicationUser = a5, Post = p8, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p9 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r9_1 = new Reply() { ApplicationUser = a1, Post = p9, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r9_2 = new Reply() { ApplicationUser = a4, Post = p9, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r9_3 = new Reply() { ApplicationUser = a5, Post = p9, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p10 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r10_1 = new Reply() { ApplicationUser = a1, Post = p10, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r10_2 = new Reply() { ApplicationUser = a4, Post = p10, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r10_3 = new Reply() { ApplicationUser = a5, Post = p10, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p11 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r11_1 = new Reply() { ApplicationUser = a1, Post = p11, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r11_2 = new Reply() { ApplicationUser = a4, Post = p11, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r11_3 = new Reply() { ApplicationUser = a5, Post = p11, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p12 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r12_1 = new Reply() { ApplicationUser = a1, Post = p12, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r12_2 = new Reply() { ApplicationUser = a4, Post = p12, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r12_3 = new Reply() { ApplicationUser = a5, Post = p12, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p13 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r13_1 = new Reply() { ApplicationUser = a1, Post = p13, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r13_2 = new Reply() { ApplicationUser = a4, Post = p13, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r13_3 = new Reply() { ApplicationUser = a5, Post = p13, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p14 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r14_1 = new Reply() { ApplicationUser = a1, Post = p14, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r14_2 = new Reply() { ApplicationUser = a4, Post = p14, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r14_3 = new Reply() { ApplicationUser = a5, Post = p14, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p15 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r15_1 = new Reply() { ApplicationUser = a1, Post = p15, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r15_2 = new Reply() { ApplicationUser = a4, Post = p15, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r15_3 = new Reply() { ApplicationUser = a5, Post = p15, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p16 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r16_1 = new Reply() { ApplicationUser = a1, Post = p16, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r16_2 = new Reply() { ApplicationUser = a4, Post = p16, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r16_3 = new Reply() { ApplicationUser = a5, Post = p16, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p17 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r17_1 = new Reply() { ApplicationUser = a1, Post = p17, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r17_2 = new Reply() { ApplicationUser = a4, Post = p17, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r17_3 = new Reply() { ApplicationUser = a5, Post = p17, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p18 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r18_1 = new Reply() { ApplicationUser = a1, Post = p18, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r18_2 = new Reply() { ApplicationUser = a4, Post = p18, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r18_3 = new Reply() { ApplicationUser = a5, Post = p18, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p19 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r19_1 = new Reply() { ApplicationUser = a1, Post = p19, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r19_2 = new Reply() { ApplicationUser = a4, Post = p19, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r19_3 = new Reply() { ApplicationUser = a5, Post = p19, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p20 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r20_1 = new Reply() { ApplicationUser = a1, Post = p20, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r20_2 = new Reply() { ApplicationUser = a4, Post = p20, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r20_3 = new Reply() { ApplicationUser = a5, Post = p20, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p21 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r21_1 = new Reply() { ApplicationUser = a1, Post = p21, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r21_2 = new Reply() { ApplicationUser = a4, Post = p21, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r21_3 = new Reply() { ApplicationUser = a5, Post = p21, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p22 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r22_1 = new Reply() { ApplicationUser = a1, Post = p22, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r22_2 = new Reply() { ApplicationUser = a4, Post = p22, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r22_3 = new Reply() { ApplicationUser = a5, Post = p22, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p23 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r23_1 = new Reply() { ApplicationUser = a1, Post = p23, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
            Reply r23_2 = new Reply() { ApplicationUser = a4, Post = p23, Text = "You may also use querySelector for css selectors", DateTime = new DateTime(2019, 07, 30, 16, 14, 0) };
            Reply r23_3 = new Reply() { ApplicationUser = a5, Post = p23, Text = "There is also querySelectorAll for multiple results", DateTime = new DateTime(2019, 07, 30, 17, 18, 0) };

            Post p24 = new Post() { ApplicationUser = a3, Title = "How to select an element", Text = "I would like to select a HTML element using JS", DateTime = new DateTime(2019, 07, 30, 16, 0, 0), Tags = new List<Tag>() { tg2, tg6 } };
            Reply r24_1 = new Reply() { ApplicationUser = a1, Post = p24, Text = "One solution is to select by id using getElementById", DateTime = new DateTime(2019, 07, 30, 16, 7, 0) };
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
