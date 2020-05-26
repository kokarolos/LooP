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
            var userId =  User.Identity.GetUserId();
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
                                    }).OrderBy(x=>x.date);

        
            return Json(replies, JsonRequestBehavior.AllowGet);
        }

        //Get Replies Count from Posts and Group them By Tags Img.
        //TODO:
        public JsonResult GetTagsPercentage()
        {
            var userId = "338f7322-393f-49d5-bba3-34f72a46a422";
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

    }
}