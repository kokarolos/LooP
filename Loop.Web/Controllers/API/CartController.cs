using Loop.Database;
using Loop.Services;
using System.Web.Http;

namespace Loop.Web.Controllers.API
{
    [RoutePrefix("api/cart")]
    public class CartController : ApiController
    {

        private readonly UnitOfWork db = new UnitOfWork(new ApplicationDbContext());

        // GET: api/cart/getfive?id=25&price=12&prodid=12

        [HttpGet]
        [Route("getfive")]
        public IHttpActionResult GetFive(string id,string price,string prodid)
        {
            var s = $"{id} {price} {prodid}";
            return Ok(s);
        }
      

    }
}
