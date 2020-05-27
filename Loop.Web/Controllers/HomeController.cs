using Loop.Services;
using System.Web.Mvc;
using Loop.Database;
using Loop.Web.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Loop.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        private readonly UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

        public ActionResult Index()
        {
            var model = GetStatistics();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [NonAction]
        private IndexStatisticViewModel GetStatistics()
        {
            var model = new IndexStatisticViewModel();
            model.UsersCount = db.Users.GetAll().Count();
            model.PostsCount = db.Posts.GetAll().Count();
            model.ProductsCount = db.Products.GetAll().Count();
            model.OrdersCount = db.Orders.GetAll().Count();
            model.RecentPosts = db.Posts.GetAll().Where(x => x.PostDate.Date == DateTime.Now.Date).Take(4);
            model.RecentProducts = db.Products.GetAll().OrderBy(x => x.InsertionDate).Take(3);
            model.RecentReplies = db.Replies.GetAll().OrderBy(x => x.PostDate).Take(3);
            model.RecomendedProducts = (from product in db.Products.GetAll()
                                        from orderedProduct in db.OrderProducts.GetAll()
                                        where orderedProduct.ProductId == product.ProductId
                                        group orderedProduct by product into productGroups
                                        select new
                                        {
                                            product = productGroups.Key.Title,
                                            numberOfOrders = productGroups.Count()
                                        })
                           .OrderByDescending(x => x.numberOfOrders).Distinct().Take(3)
                           .ToDictionary(g=> g.product, g=>g.numberOfOrders);
            return model;
        }
    }
}