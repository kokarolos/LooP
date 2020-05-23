using PayPal.Api;
using System;
using System.Collections.Generic;
using Loop.Entities.Concrete;
using System.Web.Mvc;
using Loop.Entities.Intermediate;
using Twilio.TwiML.Voice;
using System.Linq;

namespace Loop.Web.Controllers
{
    public class PaymentController : Controller
    {
        private Payment payment;

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
                    var createPayment = CreatePayment(ApiContext, baseUri + "&guid=" + guid);
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
                    return Redirect(paypalRedirectUrl);
                }
                else
                {
                    var guid = Request.Params["guid"];
                    var executePayment = ExecutePayment(ApiContext, PayerId, Session[guid] as string);

                    if (executePayment.ToString().ToLower() != "approved")
                    {
                        return View("failureView");
                    }

                }
            }
            catch (Exception)
            {
                return View("failureView");
            }

            return View("succesView");
        }

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
                var cartt = cart.OrderProducts.ToList();

                var pricesum = cartt.Sum(x => x.Price * x.Quantity).ToString();

                foreach (var product in cartt)
                {
                    itemList.items.Add(new Item()
                    {
                        name = product.Product.Title,
                        price = product.Price.ToString(),
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
                    invoice_number = "#10000",
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