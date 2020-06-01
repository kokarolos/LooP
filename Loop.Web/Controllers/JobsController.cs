using System.Web.Mvc;

namespace Loop.Web.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        //This view displaying the Job tab 
        //All Jobs are taken from api and displayed using angular
        public ActionResult Index()
        {
            return View();
        }
    }
}