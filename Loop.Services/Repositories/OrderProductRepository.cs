using System.Data.Entity;
using Loop.Entities.Intermediate;
using Loop.Services.Interfaces.Repositories;

namespace Loop.Services.Repositories
{
    public class OrderProductRepository : GenericRepository<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepository(DbContext context) : base(context)
        {

        }
    }
}
