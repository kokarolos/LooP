using Loop.Database;
using Loop.Entities.Concrete;
using Loop.Services.Interfaces.Repositories;

namespace Loop.Services.Repositories
{
    public class ProductRepository:GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
