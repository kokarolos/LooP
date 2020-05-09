using System.Data.Entity;
using Loop.Entities.Concrete;
using Loop.Services.Interfaces.Repositories;


namespace Loop.Services.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context)
        {

        }
    }
}
