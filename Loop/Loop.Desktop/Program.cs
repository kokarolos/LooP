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

            Console.WriteLine("Kalimera");

            foreach (var item in posts)
            {
                Console.WriteLine(item.Text);

                foreach (var x in item.ApplicationUsers)
                {
                    Console.WriteLine(/*x.UserName + "" +*/ x.Age);

                }
            }





        }
    }
}
