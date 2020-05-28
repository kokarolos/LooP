using Loop.Database;
using Loop.Entities;
using Loop.Entities.Concrete;
using Loop.Entities.Intermediate;
using Loop.Services;
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Loop.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork(new ApplicationDbContext());
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

            //var order = db.Orders.GetAll().ToList();
            //var op = db.OrderProducts.GetAll().ToList();
            //var op1 = new OrderProduct()
            //{
            //    Price = 12,
            //    Product = db.Products.GetById(1),
            //    ProductId = 1,
            //    Quantity = 5
            //};
            //var op2 = new OrderProduct()
            //{
            //    Price = 125,
            //    Product = db.Products.GetById(2),
            //    ProductId = 2,
            //    Quantity = 3
            //};
            //var op3 = new OrderProduct()
            //{
            //    Price = 1,
            //    Product = db.Products.GetById(3),
            //    ProductId = 3,
            //    Quantity = 1
            //};
            //var op4 = new List<OrderProduct>();
            //op4.Add(op1);
            //op4.Add(op2);
            //op4.Add(op3);
            //
            //foreach (var item in op4)
            //{
            //    Console.WriteLine(item.Product.Description);
            //    db.OrderProducts.Insert(item);
            //}
            //var o = new Order() { OrderProducts = op4.ToList() ,OrderDate = DateTime.Now};
            //db.Orders.Insert(o);
            //db.Save();



            //
            //var userId = "c925cc25-6b45-424b-832b-14b31fe9bdfb";
            //var posts = db.Posts.GetAll().Where(post => post.ApplicationUserId == userId)
            //                             .GroupBy(x => x.PostDate.Month)
            //                             .Select(y => new
            //                             {
            //                                 key = y.Key,
            //                                 count = db.Posts.GetAll()
            //                                                 .Where(post => post.ApplicationUserId == userId && post.PostDate.Month == y.Key ).ToList()
            //                             });
            //
            //


            //var userId = "9fb01166-9c35-4be6-8fcd-7634e27e7932";
            //var posts = db.Posts.GetAll()
            //                 .ToList()
            //                 .Where(post => post.ApplicationUserId == userId)
            //                 .GroupBy(x => x.PostDate.Month)
            //                 .Select(y => new
            //                 {
            //                     value = y.Key.ToString(),
            //                     data = db.Posts.GetAll()
            //                                     .ToList()
            //                                     .Where(post => post.ApplicationUserId == userId && post.PostDate.Month == y.Key).ToList().Count.ToString()
            //                 });
            //
            //foreach (var item in posts)
            //{
            //    Console.WriteLine($"{item.value} , {item.data}");
            //}



            //Get Replies Count from Posts of an user  and Group them By Tags Img.

            //var userId = "338f7322-393f-49d5-bba3-34f72a46a422";
            //var user = db.Users.GetUserById(userId);
            //var tagsPercentage = db.Posts.GetAll()
            //                              .ToList() //Posts that user replied
            //                              .Where(reply => reply.ApplicationUser == user)
            //                              .GroupBy(post => post)
            //                              .Select(x => new
            //                              {
            //                                  tagTitle = x.Key.Tags.FirstOrDefault().Title,
            //                                  repliesCount = db.Posts.GetAll().ToList()
            //                                                                    .Where(y => y.Replies.All(e => e.ApplicationUser == user))
            //                                                                    .GroupBy(q => q.Replies)
            //                                                                    .Select(q => new
            //                                                                    {
            //                                                                        Reply = q,
            //                                                                        sum = q.Key.Count()
            //                                                                    })
            //
            //
            //
            //                                  /*.Replies.Where(g => g.ApplicationUser == user ).Count()*/
            //
            //
            //                              });

            //var dic = new Dictionary<string, int>();
            //foreach (var item in tagsPercentage)
            //{
            //    if(item.repliesCount != 0)
            //    {
            //        dic.Add(item.tagTitle, item.repliesCount);
            //    }
            //}

            //
            //  var user = db.Users.GetUserById("338f7322-393f-49d5-bba3-34f72a46a422");
            //  var Replies = db.Replies.GetAll().Where(x => x.ApplicationUser == user);
            //
            //  var lista = (from i in Replies
            //               group i by i.Post into y
            //               select new
            //               {
            //                   Tags = y.Key.Tags,
            //                   count = y.Key.Replies.Count()
            //               }).AsEnumerable();
            //
            //  var dic = new Dictionary<string, string>();
            //  foreach (var item in lista)
            //  {
            //      foreach (var por in item.Tags)
            //      {
            //          if (item.Tags.Contains(por))
            //          {
            //              foreach (var w in dic)
            //              {
            //                  if (w.Key == por.Title)
            //                  {
            //                      continue;
            //                  }
            //                  else
            //                  {
            //                      dic.Add(por.Title, item.count.ToString());
            //
            //                  }
            //              }
            //          }
            //
            //      }
            //  }
            //  foreach (var item in dic)
            //  {
            //      Console.WriteLine($"{item.Key} {item.Value}");
            //  }
            //

            //var products = (from product in db.Products.GetAll()
            //                from orderedProduct in db.OrderProducts.GetAll()
            //                where orderedProduct.ProductId == product.ProductId
            //                group orderedProduct by product into productGroups
            //                select new
            //                {
            //                    product = productGroups.Key,
            //                    numberOfOrders = productGroups.Count()
            //                })
            //               .OrderByDescending(x => x.numberOfOrders).Distinct().Take(5);
            //
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.product.Title} {item.numberOfOrders}");
            //}


            //var tags = db.Posts.GetAll()
            //                  .ToList()
            //                  .SelectMany(g => g.Tags)
            //                  .Select(e => new
            //                  {
            //                      title = e.Title,
            //                      count = 1
            //                  }).GroupBy(x => x.title).Select(q => new { title = q.First().title, Value = q.Sum(x => x.count) });
            //
            //
            //

            //Tags Per post
            //
            // var userId = "360c66a2-cd83-4247-a9a0-25e466a2c5f3";
            // var user = db.Users.GetUserById(userId);
            // var tagsPercentage = db.Posts.GetAll()
            //                               .ToList() //Posts that user replied
            //                               .Where(reply => reply.ApplicationUser == user)
            //                               .SelectMany(g=>g.Tags)
            //                               .Select(e => new
            //                               {
            //                                   title = e.Title,
            //                                   count = 1
            //                               }).GroupBy(x => x.title)
            //                                 .Select(q => new 
            //                                 { 
            //                                     title = q.First().title,
            //                                     Value = q.Sum(x => x.count)
            //                                 });
            //
            //
            // foreach (var item in tagsPercentage)
            // {
            //     Console.WriteLine($"{item.title} {item.Value}");
            // }
            //

            //  var user1 = db.Users.GetUserById("360c66a2-cd83-4247-a9a0-25e466a2c5f3");
            //  var Replies = db.Replies.GetAll().Where(x => x.ApplicationUser == user1);
            //
            //  var lista1 = Replies.GroupBy(x => x.Post)
            //                      .Select(y => new
            //                      {
            //                          title = y.Key.Tags,
            //                          ass = y.Key.Replies.Count()
            //                      }).SelectMany(g => g.title)
            //                      .GroupBy(w => w.Title)
            //                      .Select(q => new
            //                      {
            //                          title = q.Key,
            //                          count = q.GroupBy(x => x.Post)
            //                      .Select(y => new
            //                      {
            //                          title = y.Key.Tags,
            //                          ass = y.Key.Replies.Count()
            //                      })
            //                      });
            //
            //
            //  foreach (var item in lista1)
            //  {
            //      foreach (var asx in item.title)
            //      {
            //          Console.WriteLine($"{asx.Key} {item.count}");
            //      }
            //  }
            //

            // //Monthly Profit
            // var op = db.Orders.GetAll()
            //                   .Where(x => x.OrderDate.Month == DateTime.Now.Month)
            //                   .SelectMany(x => x.OrderProducts)
            //                   .Select(x => x.Price)
            //                   .Sum();
            //
            //
            // Console.WriteLine($"{op}");


            //Profit Of Year
           // var profitPerMonth = db.Orders.GetAll()
           //                               .Where(x => x.OrderDate.Year == DateTime.Now.Year)
           //                               //.SelectMany(x => x.OrderProducts)
           //                               .GroupBy(x => x.OrderDate)
           //                               .Select(q => new
           //                               {
           //                                   month = q.Key.Month,
           //                                   profit = db.Orders.GetAll()
           //                                                     .Where(x => x.OrderDate.Month == q.Key.Month)
           //                                                     .SelectMany(x => x.OrderProducts)
           //                                                     .Select(x => x.Price)
           //                                                     .Sum(),
           //                               }).Distinct().ToList();
           //                               
           //
           // foreach (var item in profitPerMonth)
           // {
           //     Console.WriteLine($"{item.month} {item.profit} ");
           // }

        }
    }
}
