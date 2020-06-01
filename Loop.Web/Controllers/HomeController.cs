using Loop.Services;
using System.Web.Mvc;
using Loop.Database;
using Loop.Web.Models;
using System.Linq;
using System;
using System.Web.Security;

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

        //Not Used
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            Session.RemoveAll(); // it will clear the session at the end of request
            Session.Clear(); // it will clear the session at the end of request
            return RedirectToAction("Index", "Home");
        }


        [NonAction]
        //This method is responsible for generating all statistics
        //that are displayed in index page
        //All the counts are for the statistic section
        //Rest are for MVP Products and RecentPost
        private IndexStatisticViewModel GetStatistics()
        {
            var model = new IndexStatisticViewModel
            {
                UsersCount = db.Users.GetAll().Count(),
                PostsCount = db.Posts.GetAll().Count(),
                ProductsCount = db.Products.GetAll().Count(),
                OrdersCount = db.Orders.GetAll().Count(),
                RecentPosts = db.Posts.GetAll().Where(x => x.PostDate.Date == DateTime.Now.Date).Take(4),
                RecentProducts = db.Products.GetAll().OrderBy(x => x.InsertionDate).Take(3),
                RecentReplies = db.Replies.GetAll().OrderBy(x => x.PostDate).Take(3),
                RecomendedProducts = (from product in db.Products.GetAll()
                                      from orderedProduct in db.OrderProducts.GetAll()
                                      where orderedProduct.ProductId == product.ProductId
                                      group orderedProduct by product into productGroups
                                      select new
                                      {
                                          product = productGroups.Key.Title,
                                          numberOfOrders = productGroups.Count()
                                      })
                                           .OrderByDescending(x => x.numberOfOrders).Distinct().Take(3)
                                           .ToDictionary(g => g.product, g => g.numberOfOrders)
            };
            return model;
        }

        //View of Unity Game
        public ActionResult Quiz()
        {
            return View();
        }
    }
}