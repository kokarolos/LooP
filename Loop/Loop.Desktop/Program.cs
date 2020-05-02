using Loop.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext apcontext = new ApplicationDbContext();

            var posts = apcontext.Posts.ToList();
            foreach (var post in posts)
            {
                Console.WriteLine(post.Title);
                Console.WriteLine(post.Text);
                foreach (var reply in post.Replies)
                {
                    Console.Write("\t");
                    Console.WriteLine(reply.Text);
                }
                Console.WriteLine(new String('*', 50));
            }
        }
    }
}
