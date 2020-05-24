using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Entities.Intermediate;
using Loop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

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
            //UnitOfWork db = new UnitOfWork(new ApplicationDbContext());
            //var users = db.Users.GetAll();
            //var userProducts = db.UserProduct.GetAll();
            //var products = db.Products.GetAll();

            ////Get books by user
            //IQueryable<Book> books = (from book in products.OfType<Book>()
            //                          join user in userProducts on book.ProductId equals user.ProductId
            //                          select book).AsQueryable();

            //foreach (var user in users)
            //{
            //    foreach (var item in userProducts)
            //    {
            //        if (user.Id == item.ApplicationUser_Id)
            //        {
            //            Console.WriteLine($"{user.UserName}");
            //            foreach (var book in books)
            //            {
            //                //Just For test, EF includes some proxy numbers like -> Book_1290312903912903F
            //                //debugg it for more answers
            //                if(book.GetType().Name == item.Product.GetType().Name)
            //                {
            //                    Console.WriteLine($"{book.Title}");
            //                }
            //            }
            //            //Console.WriteLine($"{user.UserName} purchased {item.Product.GetType().Name} with title {item.Product.Title} with price {item.Price}");
            //        }
            //    }
            //}
            //foreach (var item in books)
            //{
            //    Console.WriteLine($"{item.ProductId} {item.Title}");
            //}


           //int rows = 0;
           UnitOfWork db = new UnitOfWork(new ApplicationDbContext());
            //
            //foreach (var user in db.Users.GetAll().ToList())
            //{
            //    foreach (var order in db.Orders.GetAll().ToList())
            //    {
            //        foreach (var orderProduct in db.OrderProducts.GetAll().ToList())
            //        {
            //            if (order.OrderId == orderProduct.OrderId)
            //            {
            //                Console.Write($"{user.FirstName} \t");
            //                Console.WriteLine($"{order.OrderId} {orderProduct.Product.Title} ");
            //                rows++;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(rows);

            var order = db.Orders.GetAll().ToList();
            var op = db.OrderProducts.GetAll().ToList();
            var op1 = new OrderProduct()
            {
                Price = 12,
                Product = db.Products.GetById(1),
                ProductId = 1,
                Quantity = 5
            };
            var op2 = new OrderProduct()
            {
                Price = 125,
                Product = db.Products.GetById(2),
                ProductId = 2,
                Quantity = 3
            };
            var op3 = new OrderProduct()
            {
                Price = 1,
                Product = db.Products.GetById(3),
                ProductId = 3,
                Quantity = 1
            };
            var op4 = new List<OrderProduct>();
            op4.Add(op1);
            op4.Add(op2);
            op4.Add(op3);

            foreach (var item in op4)
            {
                Console.WriteLine(item.Product.Description);
                db.OrderProducts.Insert(item);
            }
            var o = new Order() { OrderProducts = op4.ToList() ,OrderDate = DateTime.Now};
            db.Orders.Insert(o);
            db.Save();


        }
    }
}
