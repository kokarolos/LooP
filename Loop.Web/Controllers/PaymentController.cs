using System;
using PayPal.Api;
using System.Linq;
using Loop.Database;
using Loop.Services;
using System.Web.Mvc;
using Loop.Entities.Concrete;
using Microsoft.AspNet.Identity;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using Loop.Entities.Intermediate;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using System.Globalization;

namespace Loop.Web.Controllers
{
    public class PaymentController : Controller
    {
        private Payment payment;
        private readonly UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

        private ApplicationUserManager _userManager;
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

        //GET: Payment
        public ActionResult PaymentWithPaypal()
        {

            APIContext ApiContext = PayPalConfiguration.GetAPIContext();
            try
            {
                string PayerId = Request.Params["PayerID"];
                if (string.IsNullOrEmpty(PayerId))
                {
                    string baseUri = Request.Url.Scheme + "://" + Request.Url.Authority +
                        "/Payment/PaymentWithPaypal?";
                    var guid = Convert.ToString((new Random()).Next(100000000));
                    var createPayment = CreatePayment(ApiContext, baseUri + "guid=" + guid);
                    var links = createPayment.links.GetEnumerator();
                    string paypalRedirectUrl = null;

                    while (links.MoveNext())
                    {
                        Links lnk = links.Current;
                        if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                        {
                            paypalRedirectUrl = lnk.href;
                        }
                    }
                    Session.Add(guid, createPayment.id);
                    return Redirect(paypalRedirectUrl);
                }
                else
                {
                    var guid = Request.Params["guid"];
                    var executePayment = ExecutePayment(ApiContext, PayerId, Session[guid] as string);

                    if (executePayment.state.ToLower() != "approved")
                    {
                        Session.Remove("Cart");
                        return View("failureView");

                    }
                }
            }
            //for better debugging exception sending directly to failure View
            catch (Exception e)
            {
                Session.Remove("Cart");
                return View("failureView", e);
            }

            Session.Remove("Cart");
            return View("successView");
        }

        //Payment Execution getting from URL (after paypal redirection) payerid, guid as PaymentId 
        private Payment ExecutePayment(APIContext apiContext, string payerId, string PaymentId)
        {
            var paymentExecution = new PaymentExecution()
            {
                payer_id = payerId,
            };
            payment = new Payment()
            {
                id = PaymentId
            };
            return payment.Execute(apiContext, paymentExecution);
        }

        private Payment CreatePayment(APIContext apiContext, string redirectUrl)
        {
            var itemList = new ItemList() { items = new List<Item>() };

            if (!(Session["Cart"] is null))
            {
                var cart = Session["Cart"] as Cart;
                var shoppingCart = cart.OrderProducts.ToList();

                //SubTotal -> used for Paypal verifications
                var pricesum = shoppingCart.Sum(x => x.Price * x.Quantity).ToString("0.00", new CultureInfo("en-US"));

                //Creating Order -> Assign it to user and getting his cart
                //If user isnt registered, he can still checkout
                //Using Linq i insert to OrderProducts table every product he purchased

                var user = db.Users.GetUserById(User.Identity.GetUserId());
                var order = new Entities.Concrete.Order()
                {
                    ApplicationUser = user,
                    ApplicationUserId = User.Identity.GetUserId(),
                    OrderDate = DateTime.Now,
                    OrderProducts = cart.OrderProducts.ToList().Select(x=>new OrderProduct()
                    {
                        Price = x.Price,
                        Quantity = x.Quantity,
                        Product = db.Products.GetById(x.ProductId),
                        ProductId = x.ProductId
                    }).ToList()
                };
                db.Orders.Insert(order);
                var role = "Customer";
                UserManager.AddToRole(user.Id, role);

                db.Save();

                foreach (var product in shoppingCart)
                {
                    itemList.items.Add(new Item()
                    {
                        name = product.Product.Title,
                        price = product.Price.ToString("0.00", new CultureInfo("en-US")),
                        quantity = product.Quantity.ToString(),
                        currency = "USD",
                        sku = "sku"
                    });
                }

                var payer = new Payer()
                {
                    payment_method = "paypal"
                };

                var redirUrl = new RedirectUrls()
                {
                    cancel_url = redirectUrl + "&Cancel=true",
                    return_url = redirectUrl
                };

                var details = new Details()
                {
                    //string priceString = price.ToString("0.00", new CultureInfo("en-US"));
                    tax = "0",
                    shipping = "0",
                    subtotal = pricesum
                };

                var amount = new Amount()
                {
                    currency = "USD",
                    total = pricesum,
                    details = details
                };

                var transactionList = new List<Transaction>();
                transactionList.Add(new Transaction()
                {
                    description = "Transaction Description",
                    invoice_number = new Random().Next(0, 1000).ToString(),
                    amount = amount,
                    item_list = itemList
                });

                payment = new Payment()
                {
                    intent = "sale",
                    payer = payer,
                    transactions = transactionList,
                    redirect_urls = redirUrl
                };

            }
            return payment.Create(apiContext);
        }
    }
}