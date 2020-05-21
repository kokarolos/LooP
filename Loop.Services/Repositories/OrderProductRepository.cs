using System.Collections.Generic;
using System.Data.Entity;
using Loop.Database;
using Loop.Entities.Intermediate;
using Loop.Services.Interfaces.Repositories;

namespace Loop.Services.Repositories
{
    public class OrderProductRepository : GenericRepository<OrderProduct>, IOrderProductRepository
    {
        public ApplicationDbContext Database
        {
            get { return Context as ApplicationDbContext; }
        }

        public OrderProductRepository(DbContext context) : base(context)
        {

        }
        //Getting all orderProducts including Order table and Product Table
        public override IEnumerable<OrderProduct> GetAll()
        {
            return Database.OrderProducts
                                         .Include(o => o.Order)
                                         .Include(o => o.Product);
        }
    }
}
