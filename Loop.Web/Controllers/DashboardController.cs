using Loop.Database;
using Loop.Services;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Loop.Web.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        private readonly UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

        public ActionResult Index()
        {
            return View("Index");
        }

        //Get Post Per User By Month
        public JsonResult GetPosts()
        {
            var userId = User.Identity.GetUserId();
            var posts = db.Posts.GetAll()
                                .ToList()
                                .Where(post => post.ApplicationUserId == userId)
                                .GroupBy(x => x.PostDate.Month)
                                .Select(y => new
                                {
                                    date = y.Key,
                                    count = db.Posts.GetAll()
                                                 .ToList()
                                                 .Where(post => post.ApplicationUserId == userId && post.PostDate.Month == y.Key)
                                                 .ToList()
                                                 .Count.ToString()
                                });

            return Json(posts, JsonRequestBehavior.AllowGet);
        }


        //Get Replies Per User
        public JsonResult GetReplies()
        {
            var userId = User.Identity.GetUserId();
            var user = db.Users.GetUserById(userId);
            var replies = db.Replies.GetAll()
                                    .ToList()
                                    .Where(reply => reply.ApplicationUser == user)
                                    .GroupBy(x => x.PostDate.Month)
                                    .Select(y => new
                                    {
                                        date = y.Key,
                                        count = db.Posts.GetAll()
                                                     .ToList()
                                                     .Where(reply => reply.ApplicationUser == user && reply.PostDate.Month == y.Key)
                                                     .ToList()
                                                     .Count.ToString()
                                    }).OrderBy(x => x.date);


            return Json(replies, JsonRequestBehavior.AllowGet);
        }

        //Get Replies Count from Posts and Group them By Tags Img.
        //TODO:
        public JsonResult GetTagsPercentage()
        {
            var userId = User.Identity.GetUserId();
            var user = db.Users.GetUserById(userId);
            var tagsPercentage = db.Posts.GetAll()
                                          .ToList() //Posts that user replied
                                          .Where(reply => reply.ApplicationUser == user)
                                          .GroupBy(post => post)
                                          .Select(x => new
                                          {
                                              tagTitle = x.Key.Tags.FirstOrDefault().Title,
                                              repliesCount = x.Key.Replies.Where(g => g.ApplicationUser == user).Count()


                                          });

            var dic = new Dictionary<string, int>();
            foreach (var item in tagsPercentage)
            {
                if (item.repliesCount != 0)
                {
                    dic.Add(item.tagTitle, item.repliesCount);
                }
            }
            return Json(dic, JsonRequestBehavior.AllowGet);
        }


        //Getting tags of all posts that user created
        public JsonResult GetTagsFromPostOfUser()
        {
            var userId = User.Identity.GetUserId();
            var user = db.Users.GetUserById(userId);
            var tags = db.Posts.GetAll()
                                          .ToList() 
                                          .Where(post => post.ApplicationUser == user)
                                          .SelectMany(g => g.Tags)
                                          .Select(e => new
                                          {
                                              title = e.Title,
                                              count = 1
                                          }).GroupBy(x => x.title)
                                            .Select(q => new
                                            {
                                                title = q.First().title,
                                                Value = q.Sum(x => x.count)
                                            });


            return Json(tags, JsonRequestBehavior.AllowGet);
        }



        //Query to get 5 most wanted products 
        public JsonResult GetTop5Products()
        {
            //taking all products and all orderproducts 
            //for all products we calculate the count of products in all orders -> we take 5 mvp

            var products = (from product in db.Products.GetAll()
                            from orderedProduct in db.OrderProducts.GetAll()
                            where orderedProduct.ProductId == product.ProductId
                            group orderedProduct by product into productGroups
                            select new
                            {
                                product = productGroups.Key.Title,
                                numberOfOrders = productGroups.Count()
                            })
                            .OrderByDescending(x => x.numberOfOrders).Distinct().Take(5).ToList();


            return Json(products, JsonRequestBehavior.AllowGet);
        }

        //Get all posts Per Month 
        public JsonResult PostsPerMonth()
        {
            var posts = db.Posts.GetAll()
                                .ToList()
                                .GroupBy(x => x.PostDate.Month)
                                .Select(y => new
                                {
                                    date = y.Key,
                                    count = db.Posts.GetAll()
                                                 .ToList()
                                                 .Where(post => post.PostDate.Month == y.Key)
                                                 .ToList()
                                                 .Count.ToString()
                                }).OrderBy(h=>h.date);

            return Json(posts, JsonRequestBehavior.AllowGet);
        }

        //Most wanted tags-> by post
        public JsonResult GetMostWantedTags()
        {
            var tags = db.Posts.GetAll()
                                .ToList()
                                .SelectMany(g => g.Tags)
                                .Select(e => new
                                {
                                    title = e.Title,
                                    count = 1
                                }).GroupBy(x => x.title)
                                  .Select(q => new 
                                  { 
                                      title = q.First().title, 
                                      Value = q.Sum(x => x.count) 
                                  });
                                

            return Json(tags, JsonRequestBehavior.AllowGet);
        }

    }
}