using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Services;
using System;
using System.Linq;

namespace Loop.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ApplicationDbContext apcontext = new ApplicationDbContext();
            //var posts = apcontext.Posts.ToList();
            //foreach (var post in posts)
            //{
            //    Console.WriteLine(post.Title);
            //    Console.WriteLine(post.Text);
            //    foreach (var reply in post.Replies)
            //    {
            //        Console.Write("\t");
            //        Console.WriteLine(reply.Text);
            //    }
            //    Console.WriteLine(new String('*', 50));
            //}



            //Printing User and his products
            UnitOfWork db = new UnitOfWork(new ApplicationDbContext());
            var users = db.Users.GetAll();
            var userProducts = db.UserProduct.GetAll();
            var products = db.Products.GetAll();

            //Get books by user
            IQueryable<Book> books = (from book in products.OfType<Book>()
                                      join user in userProducts on book.ProductId equals user.ProductId
                                      select book).AsQueryable();

            foreach (var user in users)
            {
                foreach (var item in userProducts)
                {
                    if (user.Id == item.ApplicationUser_Id)
                    {
                        Console.WriteLine($"{user.UserName}");
                        foreach (var book in books)
                        {
                            //Just For test, EF includes some proxy numbers like -> Book_1290312903912903F
                            //debugg it for more answers
                            if(book.GetType().Name == item.Product.GetType().Name)
                            {
                                Console.WriteLine($"{book.Title}");
                            }
                        }
                        //Console.WriteLine($"{user.UserName} purchased {item.Product.GetType().Name} with title {item.Product.Title} with price {item.Price}");
                    }
                }
            }




            //foreach (var item in books)
            //{
            //    Console.WriteLine($"{item.ProductId} {item.Title}");
            //}
        }
    }
}
