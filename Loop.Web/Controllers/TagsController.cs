using Loop.Database;
using Loop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loop.Web.Controllers
{
    public class TagsController : Controller
    {
        private readonly UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

        // GET: Tags
        public JsonResult GetTags()
        {
            var tags = from tag in db.Tags.GetAll() select new {tag.Title, tag.Description, tag.ImageUrl };
            return Json(tags, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View("Index");
        }

    }
}