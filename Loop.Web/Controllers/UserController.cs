using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Loop.Database;
using Loop.Entities;
using Loop.Entities.Concrete;
using Loop.Services;
using Loop.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Collections.Generic;
using Twilio.Rest.Autopilot.V1.Assistant;

namespace Loop.Web.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private ApplicationUserManager _userManager;
        private readonly UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: User

        //TODO: 4 users per row 
        //Details on btn click of user icon
        public ActionResult Index()
        {
            var users = db.Users.GetAll().ToList();
            return View(users);

        }

        // GET: User/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var applicationUser = db.Users.GetUserById(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }

            return View(applicationUser);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
            var roleMngr = new RoleManager<IdentityRole>(roleStore);
            var roles = roleMngr.Roles.ToList();

            ViewBag.SelectedRoleId = roles
                                      .Select(x => new SelectListItem()
                                      {
                                          Value = x.Id,
                                          Text = x.Name
                                      });
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(RegisterViewModel model, HttpPostedFileBase file, string SelectedRoleId)
        {
            //TODO:Spaghetti cleanex

            if (ModelState.IsValid)
            {
                var filename = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Avatars/" + filename));
                file.SaveAs(path);

                byte[] imageSize = new byte[file.ContentLength];
                file.InputStream.Read(imageSize, 0, file.ContentLength);

                var applicationUser = CreateUser(model);
                var result = await UserManager.CreateAsync(applicationUser, model.Password);
                //TODO:REFACTOR THIS SHIT

                if (result.Succeeded)
                {
                    var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
                    var roleMngr = new RoleManager<IdentityRole>(roleStore);
                    var roles = roleMngr.Roles.ToList();

                    var role = roles.SingleOrDefault(x => x.Id == SelectedRoleId).Name;
                    var img = new Image() { User = applicationUser, Data = imageSize, ImgName = filename, ImgPath = "~/Content/Avatars/" + filename };
                    applicationUser.Images = new List<Image>() { img };
                    UserManager.AddToRole(applicationUser.Id, role);
                    db.Users.Insert(applicationUser);
                }
                return RedirectToAction("Index");
            }
            db.Save();
            //If not succeded redirect to form
            return View(model);
        }

        // GET: User/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = db.Users.GetUserById(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }

            var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
            var roleMngr = new RoleManager<IdentityRole>(roleStore);
            var roles = roleMngr.Roles.ToList();

            ViewBag.SelectedRoleId = roles
                                     .Select(x => new SelectListItem()
                                     {
                                         Value = x.Id,
                                         Text = x.Name
                                     });


            return View(applicationUser);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ApplicationUser applicationUser, HttpPostedFileBase file, string SelectedRoleId)
        {
            if (ModelState.IsValid)
            {
                //TODO: REFACTOR THIS SHIT V2
                var filename = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Avatars/" + filename));
                file.SaveAs(path);

                byte[] imageSize = new byte[file.ContentLength];
                file.InputStream.Read(imageSize, 0, file.ContentLength);
                var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
                var roleMngr = new RoleManager<IdentityRole>(roleStore);
                var roles = roleMngr.Roles.ToList();

                var role = roles.SingleOrDefault(x => x.Id == SelectedRoleId).Name;
                UserManager.RemoveFromRoles(applicationUser.Id, "Admin", "User");
                UserManager.AddToRole(applicationUser.Id, role);
                var img = new Image() { User = applicationUser, Data = imageSize, ImgName = filename, ImgPath = "~/Content/Avatars/" + filename };
                db.Users.UpdateUserWithImage(applicationUser, img);
                db.Save();
                return RedirectToAction("Index");
            }
            return View(applicationUser);
        }



        // GET: User/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = db.Users.GetUserById(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }
            return View(applicationUser);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ApplicationUser applicationUser = db.Users.GetUserById(id);
            db.Users.Remove(applicationUser);
            db.Save();

            return RedirectToAction("Index");
        }


        //Responsive for creating new User from RegisterViewModel
        private ApplicationUser CreateUser(RegisterViewModel model)
        {
            var user = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                DateOfBirth = model.DateOfBirth,
            };
            return user;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
