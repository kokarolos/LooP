using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Services;
using Loop.Web.Models;
using Twilio.Rest.Api.V2010.Account.Usage.Record;

namespace Loop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

        // GET: Products
        public ViewResult Index()
        {
            var products = db.Products.GetAll();
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            Product product = db.Products.GetById(id);
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.SelectedProduct = db.Products.GetAll()
                                                          .GroupBy(y => y.GetType().Name)
                                                          .Select(x => new SelectListItem()
                                                          {
                                                              Value = x.Key.Split('_')[0],
                                                              Text = x.Key.Split('_')[0]
                                                          });

            return View("Select");
        }


        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel model, string SelectedProduct)
        {
            if (SelectedProduct == "Book")
            {
                return View("Book");
            }
            if (SelectedProduct == "Tutorial")
            {
                return View("Tutorial");
            }
            if (model.Pages < 0)
            {
                Product tutorial = new Tutorial()
                {
                    Description = model.Description,
                    ProductionDate = model.ProductionDate,
                    Title = model.Title,
                    Duration = model.Duration.GetValueOrDefault(),
                    TutorialAuthor = model.TutorialAuthor
                };
                db.Products.Insert(tutorial);
                db.Save();

            }
            else
            {
                Book book = new Book
                {
                    BookAuthor = model.BookAuthor,
                    Description = model.Description,
                    Publisher = model.Publisher,
                    Pages = model.Pages,
                    ProductionDate = model.ProductionDate,
                    Title = model.Title,
                    //ImageFile 
                };
                db.Products.Insert(book);
                db.Save();
            }
          

            return RedirectToAction("Index");
        }


        // GET: Products/Edit/5
        [HandleError]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.GetById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,Title,Description")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Update(product);
                db.Save();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.GetById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.GetById(id);
            db.Products.Remove(product);
            db.Save();
            return RedirectToAction("Index");
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
