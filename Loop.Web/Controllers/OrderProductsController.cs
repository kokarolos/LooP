using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Loop.Database;
using Loop.Entities.Intermediate;
using Loop.Services;

namespace Loop.Web.Controllers
{
    public class OrderProductsController : Controller
    {
        private UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

        // GET: OrderProducts
        public ActionResult Index()
        {
            var orderProducts = db.OrderProducts.GetAll();
            return View(orderProducts.ToList());
        }

        //TODO: ViewModel for OrderProducts



        // GET: OrderProducts/Create
        public ActionResult Create()
        {
            ViewBag.OrderId = new SelectList(db.Orders, "OrderId", "ApplicationUserId");
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Title");
            return View();
        }

        // POST: OrderProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderId,ProductId,Price,Quantity,Dummy")] OrderProduct orderProduct)
        {
            if (ModelState.IsValid)
            {
                db.OrderProducts.Add(orderProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrderId = new SelectList(db.Orders, "OrderId", "ApplicationUserId", orderProduct.OrderId);
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Title", orderProduct.ProductId);
            return View(orderProduct);
        }

        // GET: OrderProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderProduct orderProduct = db.OrderProducts.Find(id);
            if (orderProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrderId = new SelectList(db.Orders, "OrderId", "ApplicationUserId", orderProduct.OrderId);
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Title", orderProduct.ProductId);
            return View(orderProduct);
        }

        // POST: OrderProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderId,ProductId,Price,Quantity,Dummy")] OrderProduct orderProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrderId = new SelectList(db.Orders, "OrderId", "ApplicationUserId", orderProduct.OrderId);
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Title", orderProduct.ProductId);
            return View(orderProduct);
        }

        // GET: OrderProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderProduct orderProduct = db.OrderProducts.Find(id);
            if (orderProduct == null)
            {
                return HttpNotFound();
            }
            return View(orderProduct);
        }

        // POST: OrderProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderProduct orderProduct = db.OrderProducts.Find(id);
            db.OrderProducts.Remove(orderProduct);
            db.SaveChanges();
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
