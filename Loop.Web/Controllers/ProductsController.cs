using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Services;
using Loop.Web.Models;

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
            //If user selects to create book -> book view
            //after redirection to book view selectedproduct is null so it will check for model.Pages to distinguish model as book or tut
            if (SelectedProduct == "Book")
            {
                return View("Book");
            }
            //If user selects to create book -> book view
            if (SelectedProduct == "Tutorial")
            {
                return View("Tutorial");
            }

            if (model.Pages <= 0)
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
                    ProductionDate = model.ProductionDate.GetValueOrDefault(),
                    Pages = model.Pages,
                    Publisher = model.Publisher,
                    Title = model.Title
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
            ProductViewModel model = new ProductViewModel();
            if (product == null)
            {
                return HttpNotFound();
            }
            if (product.GetType().Name.Split('_')[0] == "Book")
            {
                
                model.Description = product.Description;
                model.Title = product.Title;
                return View(model);
            }
            else
            {
                return View("Tutorial");
            }
          
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
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
      // private Product GenerateProduct(ProductViewModel model,Func<Product,bool> IsType)
      // {
      //     if (IsType())
      //     {
      //
      //     }
      // }
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
