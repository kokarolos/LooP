using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Loop.Entities;
using Loop.Entities.Concrete;
using System.Web.Mvc;


namespace Loop.Web.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        //        public ActionResult PaymentWithPaypal()
        //        {

        //        //    APIContext aPIContext = PayPalConfiguration.GetAPIContext();
        //        //    try
        //        //    {
        //        //        string PayerId = Request.Params["PayerID"];
        //        //        if (string.IsNullOrEmpty(PayerId))
        //        //        {
        //        //            string baseUri = Request.Url.Scheme + "://" + Request.Url.Authority +
        //        //                "PaymentWithPaypal/PaymentWithPaypal?";

        //        //            var Guid = Convert.ToString((new Random()).Next(100000000));
        //        //            var createPayment = this.CreatePayment(APIContext, baseUri + "guid=" + Guid);

        //        //        }
        //        //    }
        //        //    catch (Exception)
        //        //    {

        //        //        throw;
        //        //    }


        //        //    return View();
        //        //}

    }
}