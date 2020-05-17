using Loop.Services;
using System.Web.Mvc;
using Loop.Database;
using Loop.Web.Models;
using System.Linq;
using System;

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
        public ActionResult Chat()
        {
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
            model.RecentPosts = db.Posts.GetAll().Where(x => x.PostDate.Date == DateTime.Now.Date).Take(5);

            return model;
        }
    }
}