using Loop.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Loop.Database
{
    public class MyDatabase : DbContext
    {
        public MyDatabase():base("Connection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
