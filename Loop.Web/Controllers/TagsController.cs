using Loop.Database;
using Loop.Entities;
using Loop.Services;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Loop.Web.Controllers
{
    public class TagsController : Controller
    {
        private readonly UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

        // GET: Tags
        public JsonResult GetTags()
        {
            var tags = from tag in db.Tags.GetAll() select new
            {
                tag.TagId,
                tag.Title,
                tag.Description,
                tag.ImageUrl
            };
            return Json(tags, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: Tags/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tag tag = db.Tags.GetById(id);
            if (tag == null)
            {
                return HttpNotFound();
            }
            return View(tag);
        }

        public JsonResult GetTagById(int? id)
        {
            var tag = from t in db.Tags.GetAll() where t.TagId == id select new
            {
                t.TagId,
                t.Title,
                t.Description,
                t.ImageUrl,
                Posts = t.Posts.Select
                ( p => new
                    {
                        p.Title,
                        p.Text,
                        p.PostDate,
                        Tags = p.Tags.Select( tg => new { tg.TagId, tg.Title } ),
                        NumReplies = p.Replies.Select( rp => rp.ReplyId ).Count(),
                        PostedBy = p.ApplicationUser.UserName
                    }
                )

            };
            return Json(tag, JsonRequestBehavior.AllowGet);
        }



    }
}