using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Loop.Database;
using Loop.Entities.Concrete;
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



    }
}
