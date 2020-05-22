using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Entities.Intermediate;
using Loop.Services;
using Twilio.Types;

namespace Loop.Web.Controllers
{
    public class OrderProductsController : Controller
    {
        private UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

        //this is the index page of our cart
        public ActionResult Cart()
        {
            var cart = CreateOrGetCart();
            return View(cart);
        }

        private Cart CreateOrGetCart()
        {
            var cart = Session["Cart"] as Cart;
            if (cart == null)
            {
                cart = new Cart();
                SaveCart(cart);
            }
            return cart;
        }

        //Firstly we will get product from products/index on add click we get product -> redirection to Cart View

        public ActionResult Add(int ProductId)
        {
            var product = db.Products.GetAll().ToList().FirstOrDefault(x => x.ProductId == ProductId);
            var cart = CreateOrGetCart();
            //TODO:: Counter ++
            var existingItem = cart.OrderProducts.Where(x => x.ProductId == ProductId).Any();

            if (existingItem)
            {
                var e = cart.OrderProducts.GroupBy(x => db.Products.GetById(ProductId))
                                          .Select(y => new
                                          {
                                              y.Key,
                                              Quantity = y.Key.
                                          });
            }

            //TODO : If cart is Checkouted or Canceled we will Create new Order else we will keep the same
            //Maybe Delegate?

            cart.OrderProducts.Add(new OrderProduct()
            {
                //We dont need to create an order -> we will create order at checkout proccess
                Order = null,
                ProductId = ProductId,
                Product = db.Products.GetById(ProductId),
                Price = 100,
                Quantity = 1
            });


            SaveCart(cart);

            return RedirectToAction("Cart", "OrderProducts");
        }


        // orderId : 1293912
        // productId : 123
        // Quantity : 5
        // price : 50

        //If user is authenticated -> Store user to Order and match the relationship then store it db
        // Goal is from Order to get AppUser using User.Identity -> Order-> AppUser and store it 

        // orderId : 1293912
        // productId : 124
        // Quantity : 2
        // price : 50

        private void ClearCart()
        {
            var cart = new Cart();
            SaveCart(cart);
        }

        private void SaveCart(Cart cart)
        {
            Session["Cart"] = cart;
        }

        public ActionResult Delete(int ProductId)
        {
            //Get Product from db
            var product = db.Products.GetAll().FirstOrDefault(x => x.ProductId == ProductId);

            var cart = CreateOrGetCart();
            //Searching for the product in the list of OrderProducts and receiving the OrderProduct Object
            var existingItem = cart.OrderProducts.Where(x => x.ProductId == ProductId).FirstOrDefault();

            if (existingItem != null)
            {
                //Finally removing it from OrderProducts List
                cart.OrderProducts.Remove(existingItem);
            }

            SaveCart(cart);

            return RedirectToAction("Cart", "OrderProducts");
        }
    }
}
