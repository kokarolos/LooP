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
            //getting all products group them by Value(Book, or Tut) , because of Entity Proxies when i getType of Product
            //It stores it like Book_1203021302139SDIXUASUDAS so i split string from _ and taking back the first string

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
                var book = CreateBook(model);
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
            var product = db.Products.GetById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            if (product is Book book)
            {
                var model = CreateModelFromBook(book);
                return View("EditBook", model);
            }
            else
            {
                var model = CreateModelFromTutorial(product as Tutorial);
                return View("EditTutorial", model);
            }

        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel model)
        {

            if (ModelState.IsValid)
            {
                if (model.Pages > 0)
                {
                    var book = CreateBook(model);
                    db.Products.Update(book);
                    db.Save();
                    return RedirectToAction("Index");
                }
                else
                {
                    var tutorial = CreateTutorial(model);
                    db.Products.Update(tutorial);
                    db.Save();
                    return RedirectToAction("Index");
                }

            }
            return View(model);
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

        [NonAction]
        private Book CreateBook(ProductViewModel model)
        {
            var book = new Book()
            {
                ProductId = model.ProductId,
                Pages = model.Pages,
                ProductionDate = model.ProductionDate,
                Publisher = model.Publisher,
                BookAuthor = model.BookAuthor,
                Description = model.Description,
                Title = model.Title,
                PhotoUrl = model.PhotoUrl
            };
            return book;
        }

        [NonAction]
        private ProductViewModel CreateModelFromBook(Book book)
        {
            var model = new ProductViewModel()
            {
                ProductId = book.ProductId,
                Pages = book.Pages,
                ProductionDate = book.ProductionDate,
                Publisher = book.Publisher,
                BookAuthor = book.BookAuthor,
                Description = book.Description,
                Title = book.Title,
                PhotoUrl = book.PhotoUrl
            };
            return model;
        }


        [NonAction]
        private Tutorial CreateTutorial(ProductViewModel model)
        {
            var tutorial = new Tutorial()
            {
                ProductId = model.ProductId,
                Duration = model.Duration.GetValueOrDefault(),
                ProductionDate = model.ProductionDate,
                TutorialAuthor = model.TutorialAuthor,
                Description = model.Description,
                Title = model.Title,
                PhotoUrl = model.PhotoUrl
            };
            return tutorial;
        }

        [NonAction]
        private ProductViewModel CreateModelFromTutorial(Tutorial tutorial)
        {
            var model = new ProductViewModel()
            {
                ProductId = tutorial.ProductId,
                Duration = tutorial.Duration,
                ProductionDate = tutorial.ProductionDate,
                TutorialAuthor = tutorial.TutorialAuthor,
                Description = tutorial.Description,
                Title = tutorial.Title,
                PhotoUrl = tutorial.PhotoUrl
            };
            return model;
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
